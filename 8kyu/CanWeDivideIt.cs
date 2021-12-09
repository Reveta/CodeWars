namespace CodeWars._8kyu {
	public class CanWeDivideIt {
		/**
		 * https://www.codewars.com/kata/5a2b703dc5e2845c0900005a/train/csharp
		 */
		public static bool is_divide_by(int number, int a, int b) {
			return number % a + number % b == 0;
		}
	}
}