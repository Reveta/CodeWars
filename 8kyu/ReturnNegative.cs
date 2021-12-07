using System;

namespace CodeWars._8kyu {
	public class ReturnNegative {
		/**
		 * https://www.codewars.com/kata/55685cd7ad70877c23000102/train/csharp
		 * In this simple assignment you are given a number and
		 * have to make it negative. But maybe the number is already negative?
		 */
		public static int MakeNegative(int number) => Math.Abs(number) * -1;
	}
}