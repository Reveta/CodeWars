using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._8kyu {
	public class DrinkAbout {
		/**
		 * https://www.codewars.com/kata/56170e844da7c6f647000063
		 */
		public static string PeopleWithAgeDrink(int old) {
			return new Dictionary<int, string>(){
				{14, "drink toddy"},
				{18, "drink coke"},
				{21, "adults drink beer"},
				{Int32.MaxValue, "drink whisky"}
			}.First(pair => old <= pair.Key).Value;
		}

		
	}
}