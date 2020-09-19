using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;

namespace Scripts.Editor {
	public static class GeneratorPrototype {
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

			public void Write(Type type) {
				var namespaceDir = !string.IsNullOrEmpty(type.Namespace) ? string.Join("/", type.Namespace.Split('.')) : string.Empty;
				var dirPath      = $"{_targetDir}/{namespaceDir}{(!string.IsNullOrEmpty(namespaceDir) ? "/" : "")}";
				var extensionName = $"{type.Name.Replace("`", "")}Extensions";
				var filePath     = $"{dirPath}/{extensionName}.cs";
				if ( !Directory.Exists(dirPath) ) {
					Directory.CreateDirectory(dirPath);
				}
				var extensionNamespace = $"Scripts.Extensions.{type.Namespace}";
				var content            = _formatter.Format(extensionNamespace, extensionName);
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
				"\t}}\n" +
				"}}";

			public string Format(string namespaceName, string extensionName) {
				return string.Format(_classFormat, "", namespaceName, extensionName);
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
					_extensionWriter.Write(targetType.type);
				}
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