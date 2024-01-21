namespace Tool.Compet.Core;

public class DkBitwise {
	/// <summary>
	/// Check bit (1) at index of given number.
	/// </summary>
	/// <param name="value">The number</param>
	/// <param name="index">From right -> left. At rightmost, it is 0.</param>
	/// <returns></returns>
	public static bool HasBitAt(int value, int index) {
		return ((value >> index) & 1) == 1;
	}

	/// <summary>
	/// Calculate number of bit 1 in given number.
	/// </summary>
	/// <param name="x"></param>
	/// <returns></returns>
	public static int BitCount(int x) {
		var count = 0;
		for (var index = 0; index < 32; ++index) {
			if (((x >> index) & 1) == 1) {
				++count;
			}
		}
		return count;
	}
}
