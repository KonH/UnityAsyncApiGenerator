using System;
using System.Collections.Generic;
using Scripts.TestSamples;

namespace Scripts.TestSamples {
	public sealed class TargetClass {
		public sealed class NestedClass {}

		public void NonTargetMethodNoArgs() {}
		public int NonTargetMethodReturnsValue(SuccessVoidCallback callback) => 0;
		public void TargetMethodNoArguments(SuccessVoidCallback callback) {}
		public void TargetMethodWithStringArgument(string argument, SuccessVoidCallback callback) {}
		public void TargetMethodWithOptionalArgument(string argument1, string argument2 = null, SuccessVoidCallback callback = null) {}
		public void TargetMethodWithNestedArgument(NestedClass argument, SuccessVoidCallback callback) {}
		public void TargetMethodWithStringArguments(List<string> arguments, SuccessVoidCallback callback) {}
		public void TargetGenericMethod1<T>(T argument, SuccessVoidCallback callback) {}
		public void TargetGenericMethod2<T>(List<T> arguments, SuccessVoidCallback callback) {}
		public void TargetGenericMethod3<T1, T2>(List<T1> arguments1, List<T2> arguments2, SuccessVoidCallback callback) {}
		public void TargetGenericMethodWithConstraint<T>(List<T> arguments, SuccessVoidCallback callback)
			where T : class, IComparable<T>, new() {}
	}

	public sealed class TargetGenericClass<T> {
		public void TargetMethodWithArgument(T argument, SuccessVoidCallback callback) {}
	}

	public sealed class TargetGenericClassWithConstraint<T> where T : class, IComparable<T>, new() {
		public void TargetMethodWithArgument(T argument, SuccessVoidCallback callback) {}
	}
}

public sealed class TargetClassNoNamespace {
	public void TargetMethodNoArguments(SuccessVoidCallback callback) {}
}