namespace Tool.Compet.Core;

public class DkArrays {
	public static void Fill(int[] arr, int value, int startIndex, int endIndex) {
		Array.Fill(arr, value, startIndex, endIndex - startIndex + 1);
	}
}
