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
}
