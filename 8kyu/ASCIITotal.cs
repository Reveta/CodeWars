using System;
using System.Linq;

namespace CodeWars._8kyu {
	public class ASCIITotal {
		/**
		 * https://www.codewars.com/kata/572b6b2772a38bc1e700007a/train/csharp
		 * You'll be given a string, and have to return the sum of all characters as an int. The function should be able to handle all ASCII characters.
		 * examples:
		 * uniTotal("a") == 97 uniTotal("aaa") == 291
		 */
	
		public static int UniTotal(string str) {
			return str.Sum(ch => ch);
		}

		// public static void Main(string[] args) {
		// 	Console.WriteLine(UniTotal("a"));
		// }
	}
}