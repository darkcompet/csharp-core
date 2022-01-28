namespace Tool.Compet.Core {
	using System;

	public class DkObjects {
		/// Create new instance from given type.
		public static T NewInstace<T>() where T : class {
			return (T)Activator.CreateInstance<T>();
		}
	}
}
