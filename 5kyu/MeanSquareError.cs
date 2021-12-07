using System;
using System.Linq;

namespace CodeWars._5kyu {
	public class MeanSquareError {
		/**
	 * https://www.codewars.com/kata/51edd51599a189fe7f000015/train/csharp
	 * Complete the function that
	 * 
	 * accepts two integer arrays of equal length
	 * compares the value each member in one array to the corresponding member in the other
	 * squares the absolute value difference between those two values
	 * and returns the average of those squared absolute value difference between each member pair.
	 */
		public static double Solution(int[] firstArray, int[] secondArray) {
			return firstArray
				.Select((el, i) => Math.Pow(el - secondArray[i], 2))
				.Sum() / firstArray.Length;
		}
		
		public static void Main(string[] args) {
			double solution = Solution(new int[] {1, 2, 3}, new int[] {4, 5, 6});
			Console.WriteLine(solution);
		}
	}
}