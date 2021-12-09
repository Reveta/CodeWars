namespace CodeWars._8kyu {
	public class TransportationOnVacation {
		/**
		 * https://www.codewars.com/kata/568d0dd208ee69389d000016/train/csharp
		 */
		public static int RentalCarCost(int d) => d * 40 - (d >= 3 ? d >= 7 ? 50 : 20 : 0);
	}
}