using System.Linq;
using AsyncApiGenerator;
using NUnit.Framework;
using Scripts.TestSamples;

namespace Tests {
	public sealed class MethodProviderDirectTests {
		[Test]
		public void MethodIsNotPresentIfNotUseCallback() {
			var filter   = new MethodFilter("Scripts.TestSamples", typeof(SuccessVoidCallback));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(filter);

			Assert.False(result.Any(m => m.Name == nameof(TargetClass.NonTargetMethodNoArgs)));
		}

		[Test]
		public void MethodIsNotPresentIfReturnsValue() {
			var filter   = new MethodFilter("Scripts.TestSamples", typeof(SuccessVoidCallback));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(filter);

			Assert.False(result.Any(m => m.Name == nameof(TargetClass.NonTargetMethodReturnsValue)));
		}

		[Test]
		public void MethodIsPresentIfUseCallback() {
			var filter   = new MethodFilter("Scripts.TestSamples", typeof(SuccessVoidCallback));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(filter);

			Assert.True(result.Any(m => m.Name == nameof(TargetClass.TargetMethodNoArguments)));
		}

		[Test]
		public void MethodIsPresentUsingParentNamespace() {
			var filter   = new MethodFilter("Scripts", typeof(SuccessVoidCallback));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(filter);

			Assert.True(result.Any(m => m.Name == nameof(TargetClass.TargetMethodNoArguments)));
		}

		[Test]
		public void MethodsAreNotPresentForAnotherNamespace() {
			var filter   = new MethodFilter("Scripts.NonPresentNamespace", typeof(SuccessVoidCallback));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(filter);

			Assert.False(result.Any());
		}

		[Test]
		public void MethodWithoutNamespaceIsPresentIfNotSpecified() {
			var filter   = new MethodFilter(string.Empty, typeof(SuccessVoidCallback));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(filter);

			Assert.True(result.Any(m => m.Name == nameof(TargetClassNoNamespace.TargetMethodNoArguments)));
		}

		[Test]
		public void MethodWithoutNamespaceIsNotPresentIfSpecified() {
			var filter   = new MethodFilter("Scripts.TestSamples", typeof(SuccessVoidCallback));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(filter);

			Assert.False(result.Any(m => m.Name == nameof(TargetClassNoNamespace.TargetMethodNoArguments)));
		}
	}
}