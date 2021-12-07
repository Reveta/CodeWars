namespace CodeWars._8kyu {
	public class Converter {
		/**
		 * https://www.codewars.com/kata/5556282156230d0e5e000089/train/csharp
		 * Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems.
		 * It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').
		 * Ribonucleic acid, RNA, is the primary messenger molecule in cells. RNA differs slightly from DNA its
		 * chemical structure and contains no Thymine. In RNA Thymine is replaced by another nucleic acid Uracil ('U').
		 * Create a function which translates a given DNA string into RNA.
		 */
		public string dnaToRna(string dna) {
			return dna.ToUpper().Replace("T", "U");
			// Have fun! ^_^
		}
	}
}