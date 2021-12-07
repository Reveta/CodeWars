using System;
using System.Linq;

namespace CodeWars._8kyu {
	public class RemoveFirstAndLastCharacter {
		/**
		 * https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0/train/csharp
		 * It's pretty straightforward. Your goal is to create a function that
		 * removes the first and last characters of a string. You're given one
		 * parameter, the original string. You don't have to worry with strings
		 * with less than two characters.
		 */
		public static string Remove_char(string s) =>
			String.Concat(s.Where((c, i) => (i != 0) && (i != s.Length - 1)));
	}
}