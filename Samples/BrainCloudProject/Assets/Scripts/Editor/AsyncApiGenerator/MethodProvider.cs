using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor.Compilation;
using Assembly = System.Reflection.Assembly;

namespace AsyncApiGenerator {
	/// <summary>
	/// Collect required methods for further processing
	/// </summary>
	public sealed class MethodProvider {
		readonly Condition.ConditionNode _baseCondition;

		public MethodProvider(Condition.ConditionNode baseCondition = null) {
			// Use default condition because of any other return type is not supported,
			// but it can be added, if required
			_baseCondition = baseCondition ?? Condition.ReturnValue(typeof(void).FullName);
		}

		/// <summary>
		/// Retrieve all suitable by condition methods from Unity project assemblies
		/// </summary>
		public IEnumerable<MethodInfo> CollectMethods(Condition.ConditionNode condition) {
			var unityAssemblies = CompilationPipeline.GetAssemblies();
			var assemblies = unityAssemblies
				.Select(a => a.outputPath)
				.Select(Assembly.LoadFile);
			return CollectMethods(assemblies, condition);
		}

		/// <summary>
		/// Retrieve all suitable by condition methods from given assemblies
		/// </summary>
		public IEnumerable<MethodInfo> CollectMethods(IEnumerable<Assembly> assemblies, Condition.ConditionNode condition) {
			var combinedCondition = Condition.And(_baseCondition, condition);
			return assemblies
				.SelectMany(a => a.GetTypes())
				.SelectMany(t => t.GetMethods(BindingFlags.Public | BindingFlags.Instance))
				.Where(combinedCondition.IsTargetMethod);
		}
	}
}