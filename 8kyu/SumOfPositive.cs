using System.Linq;

namespace CodeWars._8kyu {
	public class SumOfPositive {
		/**
		 * https://www.codewars.com/kata/5715eaedb436cf5606000381/train/csharp
		 * You get an array of numbers, return the sum of all of the positives ones.
		 * Example [1,-4,7,12] => 1 + 7 + 12 = 20
		 * Note: if there is nothing to sum, the sum is default to 0.
		 */
		public static int PositiveSum(int[] arr) {
			return arr.ToList().FindAll(num => num > 0).Sum();
		}
	}
}