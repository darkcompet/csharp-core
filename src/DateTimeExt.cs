namespace Tool.Compet.Core {
	/// Extension for string.
	public static class DateTimeExt {
		public const string FMT_DATE = "yyyy-MM-dd";
		public const string FMT_TIME = "HH:mm:ss";
		public const string FMT_DATETIME = "yyyy-MM-dd HH:mm:ss";

		/// @param format: For eg,. yyyy-MM-dd HH:mm:ss
		/// Ref: https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
		/// Ref: https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
		public static string FormatDk(this DateTime me, string? format = FMT_DATETIME) {
			return me.ToString(format);
		}
	}
}
