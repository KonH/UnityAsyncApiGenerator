using System.Collections.Generic;
using System.Reflection;

namespace AsyncApiGenerator {
	public sealed class MethodProvider {
		public IEnumerable<MethodInfo> CollectMethods(MethodFilter filter) {
			return new MethodInfo[0];
		}
	}
}