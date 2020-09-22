using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BrainCloud;
using UnityEditor;

namespace Scripts.Editor {
	public static class GeneratorPrototype {
		readonly struct ParamInfo {
			public readonly Type   Type;
			public readonly string Name;

			public ParamInfo(Type type, string name) {
				Type = type;
				Name = name;
			}
		}

		readonly struct ExtensionInfo {
			public readonly Type        TargetType;
			public readonly string      TargetMethodName;
			public readonly ParamInfo[] TargetParams;

			public Type        ReturnType                  => typeof(string);
			public string      ReturnTypeName              => ReturnType.Name;
			public string      TargetTypeName              => TargetType.Name;
			public string      CleanTargetCallParamsLine   => FormatParamNamesOnly(CleanParams);
			public string      Name                        => $"{TargetMethodName}Async";
			public ParamInfo[] CleanParams                 => GetCleanParams(TargetParams);
			public string      CleanTargetParamsLine       => FormatParams(CleanParams);
			public string      SuccessCallbackParamsLine   => "response, cbObject";
			public string      ExceptionCallbackParamsLine => "status, code, error, cbObject";
			public string      ResultSelector              => "response";
			public Type        ExceptionType               => typeof(Exception);
			public string      ExceptionTypeName           => ExceptionType.Name;
			public string      ExceptionSelector           => "error";
			public Type[]      AllTypes                    => CollectTypes();

			public ExtensionInfo(Type targetType, string targetMethodName, ParamInfo[] targetParams) {
				TargetType       = targetType;
				TargetMethodName = targetMethodName;
				TargetParams     = targetParams;
			}

			Type[] CollectTypes() {
				var result = new List<Type> {
					typeof(TaskCompletionSource<>),
					TargetType, ReturnType
				};
				result.AddRange(CleanParams.Select(p => p.Type));
				return result.ToArray();
			}

			static string FormatParams(ParamInfo[] parameters) {
				return string.Join(", ", parameters.Select(p => $"{GetTypeName(p.Type)} {p.Name}"));
			}

			static string FormatParamNamesOnly(ParamInfo[] parameters) {
				return string.Join(", ", parameters.Select(p => p.Name));
			}

			static string GetTypeName(Type type) {
				if ( type.IsNested ) {
					return $"{type.DeclaringType?.Name}.{type.Name}";
				}
				return type.Name;
			}

			static ParamInfo[] GetCleanParams(ParamInfo[] parameters) {
				return parameters
					.Where(p => (p.Type != typeof(SuccessCallback)) && (p.Type != typeof(FailureCallback)) && (p.Name != "cbObject") && (p.Name != "cb_object"))
					.ToArray();
			}
		}

		sealed class TypeProvider {
			public Type[] GetTypes() {
				var assembly = Assembly.GetAssembly(typeof(BrainCloudWrapper));
				return assembly.GetTypes()
					.Where(t => !string.IsNullOrEmpty(t.Namespace) && t.Namespace.StartsWith("BrainCloud") && t.IsPublic)
					.ToArray();
			}
		}

		sealed class MethodProvider {
			public MethodInfo[] GetMethods(Type type) {
				return type.GetMethods(BindingFlags.Instance | BindingFlags.Public)
					.Where(m => m.ReturnType == typeof(void))
					.Where(m => m.GetParameters().Any(p => p.ParameterType == typeof(SuccessCallback)))
					.Where(m => m.GetParameters().Any(p => p.ParameterType == typeof(FailureCallback)))
					.Where(m => !m.GetParameters().Any(p => p.ParameterType.IsGenericType))
					.ToArray();
			}
		}

		sealed class ExtensionWriter {
			readonly string _targetDir = "Assets/Scripts/Extensions";

			readonly ExtensionFormatter _formatter = new ExtensionFormatter();

			public void CleanUp() {
				if ( Directory.Exists(_targetDir) ) {
					Directory.Delete(_targetDir, true);
				}
			}

			public void Write(Type type, ExtensionInfo[] extensions) {
				var namespaceDir = !string.IsNullOrEmpty(type.Namespace) ? string.Join("/", type.Namespace.Split('.')) : string.Empty;
				var dirPath      = $"{_targetDir}/{namespaceDir}{(!string.IsNullOrEmpty(namespaceDir) ? "/" : "")}";
				var extensionName = $"{type.Name.Replace("`", "")}Extensions";
				var filePath     = $"{dirPath}/{extensionName}.cs";
				if ( !Directory.Exists(dirPath) ) {
					Directory.CreateDirectory(dirPath);
				}
				var extensionNamespace = $"Scripts.Extensions.{type.Namespace}";
				var extensionBodies    = extensions.Select(e => _formatter.FormatMethod(e)).ToArray();
				var body               = _formatter.FormatBody(extensionBodies);
				var useNamespaces      = extensions.SelectMany(e => e.AllTypes).Select(t => t.Namespace).Distinct().Where(ns => !string.IsNullOrWhiteSpace(ns)).ToArray();
				var content            = _formatter.FormatClass(useNamespaces, extensionNamespace, extensionName, body);
				File.WriteAllText(filePath, content);
			}
		}

		sealed class ExtensionFormatter {
			readonly string _classFormat =
				"{0}\n" + // using block
				"\n" +
				"namespace {1}\n" + // namespace block
				"{{\n" +
				"\tpublic static class {2}\n" + // class name
				"\t{{\n" +
				"{3}" + // body
				"\t}}\n" +
				"}}";

			readonly string _methodFormat =
				// Response type, extension name, extension target, extension params
				"\t\tpublic static Task<{0}> {1}(this {2} self{3})\n" +
				"\t\t{{\n" +
				// Completion type
				"\t\t\tvar tcs = new TaskCompletionSource<{4}>();\n" +
				// Extending method
				"\t\t\tself.{5}(\n" +
				// Extending params without callbacks
				"\t\t\t\t{6}\n" +
				// Success callback params, result selector
				"\t\t\t\t({7}) => tcs.SetResult({8}),\n" +
				// Exception callback params, exception type, exception selector
				"\t\t\t\t({9}) => tcs.SetException(new {10}({11})));\n" +
				"\t\t\treturn tcs.Task;\n" +
				"\t\t}}\n";

			public string FormatClass(string[] useNamespaces, string namespaceName, string extensionName, string body) {
				return string.Format(
					_classFormat,
					string.Join("\n", useNamespaces.Select(ns => $"using {ns};")), namespaceName, extensionName, body);
			}

			public string FormatBody(string[] methods) {
				return string.Join("\n", methods);
			}

			public string FormatMethod(ExtensionInfo info) {
				var argPrefix = (info.CleanParams.Length > 0) ? ", " : string.Empty;
				var argSuffix = (info.CleanParams.Length > 0) ? "," : string.Empty;
				return string.Format(
					_methodFormat,
					info.ReturnTypeName, info.Name, info.TargetTypeName, argPrefix + info.CleanTargetParamsLine,
					info.ReturnTypeName, info.TargetMethodName, info.CleanTargetCallParamsLine + argSuffix,
					info.SuccessCallbackParamsLine, info.ResultSelector, info.ExceptionCallbackParamsLine,
					info.ExceptionTypeName, info.ExceptionSelector);
			}
		}

		sealed class ApiGenerator {
			readonly TypeProvider    _typeProvider;
			readonly MethodProvider  _methodProvider;
			readonly ExtensionWriter _extensionWriter;

			public ApiGenerator() {
				_typeProvider    = new TypeProvider();
				_methodProvider  = new MethodProvider();
				_extensionWriter = new ExtensionWriter();
			}

			public void Generate() {
				_extensionWriter.CleanUp();
				var types = _typeProvider.GetTypes();
				var targetTypes = types
					.Select(t => (type: t, methods: _methodProvider.GetMethods(t)))
					.Where(p => p.methods.Length > 0)
					.ToArray();
				foreach ( var targetType in targetTypes ) {
					var extensions = targetType.methods.Select(CreateExtension).ToArray();
					_extensionWriter.Write(targetType.type, extensions);
				}
			}

			ExtensionInfo CreateExtension(MethodInfo method) {
				var targetType = method.DeclaringType;
				var parameters = method.GetParameters().Select(p => new ParamInfo(p.ParameterType, p.Name)).ToArray();
				return new ExtensionInfo(targetType, method.Name, parameters);
			}
		}

		[MenuItem("ApiGenerator/Generate")]
		public static void Perform() {
			var generator = new ApiGenerator();
			generator.Generate();
			AssetDatabase.Refresh();
		}
	}
}