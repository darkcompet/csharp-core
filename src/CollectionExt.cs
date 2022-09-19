namespace Tool.Compet.Core {
	/// Extension for collection (array, list, set, map,...).
	public static class CollectionExt {
		public static bool IsEmptyDk<T>(this T[]? me) {
			return me == null || me.Length == 0;
		}

		public static bool IsEmptyDk<T>(this List<T>? me) {
			return me == null || me.Count == 0;
		}
	}
}
