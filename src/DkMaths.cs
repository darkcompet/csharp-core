namespace Tool.Compet.Core {
	public class DkMaths {
		/// Fast pow with O(logN) time.
		/// Method 1: x^9 = x^0 * x^1 * x^0 * x^0 * x^8. Note: 9 = 1001.
		/// Method 2: x^9 = x^4 * x^4 * x
		public static long Pow(long x, uint n) {
			var result = 1L;
			while (n > 0) {
				// Mul if meet bit 1
				if ((n & 1) == 1) {
					result = (result * x); // Mod here
				}
				// Down n and Up x
				n >>= 1;
				x = (x * x); // Mod here
			}

			return result;
		}

		/// Calculate polynomial function: y(x) = c + x * (b + x * (a + x * 0))
		public static long Poly(long[] arr, long x) {
			var result = 0L;
			for (int index = 0, N = arr.Length; index < N; ++index) {
				result = arr[index] + x * result;
			}
			return result;
		}
	}
}
