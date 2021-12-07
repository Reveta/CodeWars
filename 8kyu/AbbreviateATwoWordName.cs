using System;
using System.Linq;
using System.Text;

namespace CodeWars._8kyu {
	public class Kata2
	{
		/**
		 * https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3/train/csharp
		 * Write a function to convert a name into initials.
		 * This kata strictly takes two words with one space in between them.
		 * The output should be two capital letters with a dot separating them.
		 * It should look like this:
		 * Sam Harris => S.H
		 * patrick feeney => P.F
		 */
		public static string AbbrevName(string name) {
			return name
				.Split(" ")
				.ToList()
				.Select(word => word.ToUpper()[0].ToString())
				.Aggregate((ch1, ch2) => ch1 + "." + ch2);
		}
	}
}