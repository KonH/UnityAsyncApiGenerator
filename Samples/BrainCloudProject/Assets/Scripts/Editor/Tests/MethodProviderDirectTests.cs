using System.Linq;
using AsyncApiGenerator;
using NUnit.Framework;
using Scripts.TestSamples;

namespace Tests {
	public sealed class MethodProviderDirectTests {
		[Test]
		public void IsTypeFound() {
			var condition = Condition.Any();
			var provider  = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.True(result.Any(m => m.DeclaringType == typeof(TargetClass)));
		}

		[Test]
		public void MethodIsNotPresentIfNotUseCallback() {
			var condition = Condition.And(
				Condition.MethodNamespace("Scripts.TestSamples"),
				Condition.Parameter("SuccessVoidCallback"));
			var provider  = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.False(result.Any(m => m.Name == nameof(TargetClass.NonTargetMethodNoParams)));
		}

		[Test]
		public void MethodIsNotPresentIfReturnsValue() {
			var condition = Condition.And(
				Condition.MethodNamespace("Scripts.TestSamples"),
				Condition.Parameter("SuccessVoidCallback"));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.False(result.Any(m => m.Name == nameof(TargetClass.NonTargetMethodReturnsValue)));
		}

		[Test]
		public void MethodIsPresentIfUseCallback() {
			var condition = Condition.And(
				Condition.MethodNamespace("Scripts.TestSamples"),
				Condition.Parameter("SuccessVoidCallback"));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.True(result.Any(m => m.Name == nameof(TargetClass.TargetMethodNoParams)));
		}

		[Test]
		public void MethodIsPresentUsingParentNamespace() {
			var condition = Condition.And(
				Condition.MethodNamespace("Scripts.TestSamples"),
				Condition.Parameter("SuccessVoidCallback"));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.True(result.Any(m => m.Name == nameof(TargetClass.TargetMethodNoParams)));
		}

		[Test]
		public void MethodsAreNotPresentForAnotherNamespace() {
			var condition = Condition.And(
				Condition.MethodNamespace("Scripts.NonPresentNamespace"),
				Condition.Parameter("SuccessVoidCallback"));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.False(result.Any());
		}

		[Test]
		public void MethodWithoutNamespaceIsPresentIfNotSpecified() {
			var condition = Condition.Parameter("SuccessVoidCallback");
			var provider  = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.True(result.Any(m => m.Name == nameof(TargetClassNoNamespace.TargetMethodNoArguments)));
		}

		[Test]
		public void MethodWithoutNamespaceIsNotPresentIfSpecified() {
			var condition = Condition.And(
				Condition.MethodNamespace("Scripts.TestSamples"),
				Condition.Parameter("SuccessVoidCallback"));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.False(result.Any(m => m.Name == nameof(TargetClassNoNamespace.TargetMethodNoArguments)));
		}

		[Test]
		public void MethodWithNestedParameterIsPresentForFullName() {
			var condition = Condition.And(
				Condition.MethodNamespace("Scripts.TestSamples"),
				Condition.Parameter("Scripts.TestSamples.TargetClass.NestedClass"));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.True(result.Any(m => m.Name == nameof(TargetClass.TargetMethodWithNestedParam)));
		}

		[Test]
		public void MethodWithNestedParameterIsPresentForPartialName() {
			var condition = Condition.And(
				Condition.MethodNamespace("Scripts.TestSamples"),
				Condition.Parameter("TargetClass.NestedClass"));
			var provider = new MethodProvider();

			var result = provider.CollectMethods(condition);

			Assert.True(result.Any(m => m.Name == nameof(TargetClass.TargetMethodWithNestedParam)));
		}
	}
}