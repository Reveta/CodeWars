using System;
using System.Collections.Generic;
using System.Threading;

namespace CodeWars._8kyu {
	public class ILoveYou_ALittleALotPassionately {
		/**
		 * https://www.codewars.com/kata/57f24e6a18e9fad8eb000296/train/csharp
		 */
		public static string HowMuchILoveYou(int nbPetals) {
			var phrases = new List<string>() {
				"I love you",
				"a little",
				"a lot",
				"passionately",
				"madly",
				"not at all"
			};

			if (nbPetals <= 0) phrases.Reverse();
			int petals = (Math.Abs(nbPetals) > phrases.Count
				? nbPetals - phrases.Count * (nbPetals / phrases.Count)
				: Math.Abs(nbPetals)) - 1;
			
			return petals >= 0 ? phrases[petals] : HowMuchILoveYou(petals);
		}

		public static void Main(string[] args) {
			Console.WriteLine(HowMuchILoveYou(7));
			// Console.WriteLine(HowMuchILoveYou(44911));
			// Console.WriteLine(HowMuchILoveYou(0));
			// Console.WriteLine(HowMuchILoveYou(7000));
			// Console.WriteLine(HowMuchILoveYou(-1));
			// Console.WriteLine();
			// Console.WriteLine(HowMuchILoveYou(18900));
			// Console.WriteLine(HowMuchILoveYou(-100));
			// Console.WriteLine(HowMuchILoveYou(-1));
			// Console.WriteLine(HowMuchILoveYou(4));
			// Console.WriteLine(HowMuchILoveYou(15));
		}
	}
}