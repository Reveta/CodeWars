namespace CodeWars._8kyu {
	public class CorrectTheMistakesOfTheCharacterRecognitionSoftware {
		/**
		 * https://www.codewars.com/kata/577bd026df78c19bca0002c0/train/csharp
		 */
		public static string Correct(string text)
		{
			return text
				.Replace("5", "S")
				.Replace("0", "O")
				.Replace("1", "I");
		}
	}
}