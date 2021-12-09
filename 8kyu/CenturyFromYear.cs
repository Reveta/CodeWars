using System;

namespace CodeWars._8kyu {
	public class CenturyFromYear {
		/**
		 * https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097/train/csharp
		 */
		public static int СenturyFromYear(int year) {
			Console.WriteLine(year);
			return int.Parse(year.ToString()[..(year.ToString().Length - 2)]) + (year % 10 == 0 ? 0 : 1);
		}
	}
}