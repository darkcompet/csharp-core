namespace Tool.Compet.Core {
	/// Extension for string.
	public static class StringExt {
		/// Compare 2 strings with `Ordinal` comparision (byte-level).
		public static bool EqualsDk(this string? me, string? other) {
			return me == null ? other == null : me.Equals(other, System.StringComparison.Ordinal);
		}

		/// Compare 2 strings with `OrdinalIgnoreCase` comparision (byte-level).
		public static bool EqualsIgnoreCaseDk(this string? me, string? other) {
			return me == null ? other == null : me.Equals(other, System.StringComparison.OrdinalIgnoreCase);
		}

		public static bool IsEmptyDk(this string? me) {
			return me == null || me.Length == 0;
		}

		public static bool IsNotEmptyDk(this string? me) {
			return me != null && me.Length > 0;
		}

		/// Check this string starts with given `value` by comparing as `Ordinal` (byte-level).
		public static bool StartsWithDk(this string me, string value) {
			return me.StartsWith(value, System.StringComparison.Ordinal);
		}

		/// Check this string ends with given `value` by comparing as `Ordinal` (byte-level).
		public static bool EndsWithDk(this string me, string value) {
			return me.EndsWith(value, System.StringComparison.Ordinal);
		}

		public static string SubstringDk(this string me, int startIndex) {
			return me.Substring(startIndex, me.Length - startIndex);
		}

		public static string SubstringDk(this string me, int startIndex, int endIndex) {
			return me.Substring(startIndex, endIndex - startIndex);
		}

		public static bool ParseBooleanDk(this string? me, bool defaultValue = false) {
			if (me.EqualsDk("1") || me.EqualsIgnoreCaseDk("true")) {
				return true;
			}
			return defaultValue;
		}

		public static int ParseIntDk(this string? me, int defaultValue = 0) {
			if (int.TryParse(me, out var result)) {
				return result;
			}
			return defaultValue;
		}

		public static long ParseLongDk(this string? me, long defaultValue = 0L) {
			if (long.TryParse(me, out var result)) {
				return result;
			}
			return defaultValue;
		}

		public static float ParseFloatDk(this string? me, float defaultValue = 0F) {
			if (float.TryParse(me, out var result)) {
				return result;
			}
			return defaultValue;
		}

		public static double ParseDoubleDk(this string? me, double defaultValue = 0D) {
			if (double.TryParse(me, out var result)) {
				return result;
			}
			return defaultValue;
		}
	}
}
