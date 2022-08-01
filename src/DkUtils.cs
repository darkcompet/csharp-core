namespace Tool.Compet.Core {
	using System;

	public class DkUtils {
		/// @return Number of milliseconds that have elapsed from 1970-01-01T00:00:00.000Z..
		public static long currentUnixTimeInMillis => DateTimeOffset.Now.ToUnixTimeMilliseconds();
	}
}
