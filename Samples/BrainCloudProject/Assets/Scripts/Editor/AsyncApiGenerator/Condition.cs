using System;
using System.Linq;
using System.Reflection;

namespace AsyncApiGenerator {
	/// <summary>
	/// Representation of method filter conditions,
	/// uses tree structure and conditions can be combined for any purpose
	/// </summary>
	public static class Condition {
		public abstract class ConditionNode {
			public abstract bool IsTargetMethod(MethodInfo method);

			protected bool IsTargetTypeName(Type type, string typeName) {
				if ( type == null ) {
					return false;
				}
				// Provided type name can contains namespace or defined class name for nested classes
				// Also, we want to support non-canonical syntax like 'Owner.Child' instead of 'Owner+Child'
				// because of standard syntax can leads to misunderstanding
				if ( !typeName.Contains(".") && !typeName.Contains("+") ) {
					return type.Name == typeName;
				}
				if ( type.FullName == typeName ) {
					// Simple case: both names are fully qualified in standard way
					return true;
				}
				var fullName = type.FullName;
				if ( string.IsNullOrEmpty(fullName) ) {
					return false;
				}
				var nonStandardFullName = fullName.Replace('+', '.');
				if ( nonStandardFullName == typeName ) {
					// Complex case: provided type name contains '.' instead of '+' for partial class
					return true;
				}
				// More complex case: provided type does not include namespace
				var fullNameParts = nonStandardFullName.Split('.').Reverse().ToArray();
				var typeNameParts = typeName.Replace('+', '.').Split('.', '+').Reverse().ToArray();
				var minLength     = Math.Min(fullNameParts.Length, typeNameParts.Length);
				for ( var i = 0; i < minLength; i++ ) {
					if ( fullNameParts[i] != typeNameParts[i] ) {
						return false;
					}
				}
				return true;
			}
		}

		sealed class AnyNode : ConditionNode {
			public override bool IsTargetMethod(MethodInfo method) => true;
		}

		sealed class NamespaceConditionNode : ConditionNode {
			readonly string _namespace;

			public NamespaceConditionNode(string @namespace) {
				_namespace = @namespace;
			}

			public override bool IsTargetMethod(MethodInfo method) =>
				method.DeclaringType?.Namespace?.StartsWith(_namespace) ?? false;
		}

		sealed class OwnerTypeConditionNode : ConditionNode {
			readonly string _typeName;

			public OwnerTypeConditionNode(string typeName) {
				_typeName = typeName;
			}

			public override bool IsTargetMethod(MethodInfo method) =>
				IsTargetTypeName(method.DeclaringType, _typeName);
		}

		sealed class ParameterConditionNode : ConditionNode {
			readonly string _typeName;

			public ParameterConditionNode(string typeName) {
				_typeName = typeName;
			}

			public override bool IsTargetMethod(MethodInfo method) =>
				method.GetParameters().Any(p => IsTargetTypeName(p.ParameterType, _typeName));
		}

		sealed class ReturnTypeNode : ConditionNode {
			readonly string _typeName;

			public ReturnTypeNode(string typeName) {
				_typeName = typeName;
			}

			public override bool IsTargetMethod(MethodInfo method) =>
				IsTargetTypeName(method.ReturnType, _typeName);
		}

		sealed class AndNodeCombinator : ConditionNode {
			readonly ConditionNode[] _children;

			public AndNodeCombinator(ConditionNode[] children) {
				_children = children;
			}

			public override bool IsTargetMethod(MethodInfo method) =>
				_children.All(c => c.IsTargetMethod(method));
		}

		sealed class OrNodeCombinator : ConditionNode {
			readonly ConditionNode[] _children;

			public OrNodeCombinator(ConditionNode[] children) {
				_children = children;
			}

			public override bool IsTargetMethod(MethodInfo method) =>
				_children.Any(c => c.IsTargetMethod(method));
		}

		internal static ConditionNode ReturnValue(string typeName) =>
			new ReturnTypeNode(typeName);

		internal static ConditionNode ReturnValue(Type type) => ReturnValue(type.FullName);

		public static ConditionNode Any() =>
			new AnyNode();

		public static ConditionNode MethodNamespace(string @namespace) =>
			new NamespaceConditionNode(@namespace);

		public static ConditionNode MethodOwner(string typeName) =>
			new OwnerTypeConditionNode(typeName);

		public static ConditionNode MethodOwner(Type type) => MethodOwner(type.FullName);

		public static ConditionNode Parameter(string typeName) =>
			new ParameterConditionNode(typeName);

		public static ConditionNode Parameter(Type type) => Parameter(type.FullName);

		public static ConditionNode And(params ConditionNode[] nodes) =>
			new AndNodeCombinator(nodes);

		public static ConditionNode Or(params ConditionNode[] nodes) =>
			new OrNodeCombinator(nodes);
	}
}