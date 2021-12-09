using System;
using System.Collections.Generic;
using System.Threading;

namespace CodeWars._8kyu {
	public class ILoveYou_ALittleALotPassionately {
		/**
		 * https://www.codewars.com/kata/57f24e6a18e9fad8eb000296/train/csharp
		 */
		public static string HowMuchILoveYou(int nbPetals) {
			Console.WriteLine("Input " + nbPetals);
			int count = _phrases.Count;
			if (nbPetals > 0) {
			} else {
				_phrases.Reverse();
			}

			nbPetals = nbPetals > 0 ? nbPetals : Math.Abs(nbPetals);
			// Console.WriteLine(_phrases[0]);


			int petals = (nbPetals > count ? nbPetals - count * (nbPetals / count) : nbPetals) - 1;
			Thread.Sleep(1000);
			if (petals >= 0) {
				string howMuchILoveYou = _phrases[petals];
				Console.WriteLine("Try Answer: " + howMuchILoveYou);
				return petals >= 0 ? howMuchILoveYou : HowMuchILoveYou(petals);
			}
			
			return petals > 0 ? _phrases[petals] : HowMuchILoveYou(petals);
		}

		private static List<string> _phrases = new List<string>() {
			"I love you",
			"a little",
			"a lot",
			"passionately",
			"madly",
			"not at all"
		};

	}
}