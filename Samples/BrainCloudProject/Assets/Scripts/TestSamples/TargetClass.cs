using System;
using System.Collections.Generic;
using Scripts.TestSamples;

namespace Scripts.TestSamples {
	public sealed class TargetClass {
		public sealed class NestedClass {}

		public void NonTargetMethodNoParams() {}
		public int NonTargetMethodReturnsValue(SuccessVoidCallback callback) => 0;
		public void TargetMethodNoParams(SuccessVoidCallback callback) {}
		public void TargetMethodWithStringParam(string argument, SuccessVoidCallback callback) {}
		public void TargetMethodWithOptionalParam(string argument1, string argument2 = null, SuccessVoidCallback callback = null) {}
		public void TargetMethodWithNestedParam(NestedClass argument, SuccessVoidCallback callback) {}
		public void TargetMethodWithStringParam(List<string> arguments, SuccessVoidCallback callback) {}
		public void TargetGenericMethod1<T>(T argument, SuccessVoidCallback callback) {}
		public void TargetGenericMethod2<T>(List<T> arguments, SuccessVoidCallback callback) {}
		public void TargetGenericMethod3<T1, T2>(List<T1> arguments1, List<T2> arguments2, SuccessVoidCallback callback) {}
		public void TargetGenericMethodWithConstraint<T>(List<T> arguments, SuccessVoidCallback callback)
			where T : class, IComparable<T>, new() {}
	}

	public sealed class TargetGenericClass<T> {
		public void TargetMethodWithParam(T argument, SuccessVoidCallback callback) {}
	}

	public sealed class TargetGenericClassWithConstraint<T> where T : class, IComparable<T>, new() {
		public void TargetMethodWithParam(T argument, SuccessVoidCallback callback) {}
	}
}

public sealed class TargetClassNoNamespace {
	public void TargetMethodNoArguments(SuccessVoidCallback callback) {}
}