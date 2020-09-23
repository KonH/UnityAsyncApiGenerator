using System.Linq;
using AsyncApiGenerator;
using NUnit.Framework;

namespace Tests {
	public sealed class MethodProviderModuleTests {
		[Test]
		public void IsTypeFound() {
			var condition = Condition.Any();
			var provider  = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.True(result.Any(m => m.DeclaringType?.Name == "ModuleTargetClass"));
		}

		[Test]
		public void MethodIsNotPresentIfNotUseCallback() {
			var condition = Condition.And(
				Condition.MethodNamespace("Scripts.TestSamples.Module"),
				Condition.Parameter("SuccessVoidCallback"));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.False(result.Any(m => m.Name == "NonTargetModuleMethod"));
		}

		[Test]
		public void MethodIsPresentIfUseCallback() {
			var condition = Condition.And(
				Condition.MethodNamespace("Scripts.TestSamples.Module"),
				Condition.Parameter("SuccessVoidCallback"));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.True(result.Any(m => m.Name == "TargetModuleMethodNoParams"));
		}
	}
}