namespace Tool.Compet.Core {
	public class DkMaths {
		/// Perform fast pow via binary method.
		/// Method 1: express n as binary (0, 1)
		/// 19 = 10011
		/// x^19 = x^(2^4) * x^(2^1) * x^(2^0)
		/// Method 2: split n as binary
		/// x => x^2 => x^4 => x^9 => x^19
		/// path: 0011, 19 = 10011
		public static long Pow(long x, int n) {
			if (n < 0) {
				return 0;
			}
			if (n == 0) {
				return x == 0 ? 0 : 1;
			}
			var res = 1L;
			while (n > 0) {
				if ((n & 1) == 1) {
					res = (res * x); // mod here
				}
				n >>= 1;
				x = (x * x); // mod here
			}

			return res;
		}
	}
}
