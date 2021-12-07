using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._8kyu {
	public class CountingSheep {
		/**
	 * Consider an array/list of sheep where some sheep may be missing from their place.
	 * We need a function that counts the number of sheep present in the array (true means present).
	 */
		public static int CountSheeps(bool[] sheeps) {
			return new List<bool>(sheeps).FindAll(b => b).Count;
		}

		// public static void Main(string[] args) {
		// 	int countSheeps = CountSheeps(new[] { true, false, true });
		// 	Console.WriteLine(countSheeps);
		// }
	}
}