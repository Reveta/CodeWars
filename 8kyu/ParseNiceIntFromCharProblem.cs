namespace CodeWars._8kyu {
	public class ParseNiceIntFromCharProblem {
		/**
		 * https://www.codewars.com/kata/557cd6882bfa3c8a9f0000c1/train/csharp
		 */
		public static int GetAge(string inputString) {
			return int.Parse(inputString.Split(" ")[0]);
		}
	}
}