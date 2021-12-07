using System;

namespace CodeWars._8kyu {
	public class StringRepeat {
		/**
		 * Write a function called repeatStr which repeats the given string string exactly n times.
		 */
		public static class Program {
			public static string RepeatStr(int n, string s) {
				var result = "";
				for (var i = 1; i <= n; i++) {
					result += s;
				}

				return result;
			}
		}
	}
}