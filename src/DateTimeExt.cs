namespace Tool.Compet.Core {
	/// Extension for string.
	public static class DateTimeExt {
		/// @param format: For eg,. yyyy-MM-dd HH:mm:ss
		/// Ref: https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
		/// Ref: https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
		public static string FormatDk(this DateTime me, string? format = "yyyy-MM-dd HH:mm:ss") {
			return me.ToString(format);
		}
	}
}
