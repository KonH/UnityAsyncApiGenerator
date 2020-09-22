using System;

namespace AsyncApiGenerator {
	public readonly ref struct MethodFilter {
		public readonly string TargetNamespace;
		public readonly Type   TargetType;

		public MethodFilter(string targetNamespace, Type targetType) {
			TargetNamespace = targetNamespace;
			TargetType      = targetType;
		}
	}
}