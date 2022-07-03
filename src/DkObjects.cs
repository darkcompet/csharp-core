namespace Tool.Compet.Core {
	using System;
	using System.Reflection;

	public class DkObjects {
		/// Create new instance from given type.
		/// Throws exception if occured.
		public static T NewInstace<T>() where T : class {
			return (T)Activator.CreateInstance(
				typeof(T),
				BindingFlags.CreateInstance | BindingFlags.Public | BindingFlags.Instance | BindingFlags.OptionalParamBinding,
				null,
				new Object[] { Type.Missing },
				null
			)!;
		}
	}
}
