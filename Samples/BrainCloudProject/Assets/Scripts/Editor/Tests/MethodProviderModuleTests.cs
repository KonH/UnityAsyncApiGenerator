using System.Linq;
using AsyncApiGenerator;
using NUnit.Framework;
using Scripts.TestSamples;

namespace Tests {
	public sealed class MethodProviderModuleTests {
		[Test]
		public void MethodIsNotPresentIfNotUseCallback() {
			var filter   = new MethodFilter("Scripts.TestSamples", typeof(SuccessVoidCallback));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(filter);

			Assert.False(result.Any(m => m.Name == "NonTargetModuleMethod"));
		}

		[Test]
		public void MethodIsPresentIfUseCallback() {
			var filter   = new MethodFilter("Scripts.TestSamples", typeof(SuccessVoidCallback));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(filter);

			Assert.True(result.Any(m => m.Name == "TargetModuleMethodNoArguments"));
		}
	}
}