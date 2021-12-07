using System;
using System.Linq;

namespace CodeWars._8kyu {
	public class ReversedStrings {
		/**
		 * https://www.codewars.com/kata/5168bb5dfe9a00b126000018/train/csharp
		 * Complete the solution so that it reverses the string passed into it.
		 */
		public static string Solution(string str) {
			return String.Concat(str.Reverse());
		}
	}
}