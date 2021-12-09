using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._8kyu {
	public class CalculateBMI {
		/**
		 * https://www.codewars.com/kata/57a429e253ba3381850000fb/train/csharp
		 */
		public static string Bmi(double weight, double height) {
			return new Dictionary<double, string>() {
				{ 18.5, "Underweight" },
				{ 25, "Normal" },
				{ 30, "Overweight" },
				{ Int32.MaxValue, "Obese" },
			}.First(pair => weight / Math.Pow(height, 2) <=  pair.Key).Value;
		}
	}
}