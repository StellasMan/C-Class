using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSorts
{
	public class StringSort
	{
		public StringSort(string[] StringArray)
		{
			arrStrings = StringArray;
		}

		public string[] Sort()
		{
			// Sorting - String sort
			for (int i = 0; i < arrStrings.Length; i++)
			{
				for (int j = i + 1; j < arrStrings.Length; j++)
				{
					if (arrStrings[i].CompareTo(arrStrings[j]) > 0)
					{
						StringSwap(ref arrStrings[i], ref arrStrings[j]);
					}
				}
			}

			return arrStrings;
		}

		private void StringSwap(ref string IntVal1, ref string IntVal2)
		{
			string TempVal = IntVal1;
			IntVal1 = IntVal2;
			IntVal2 = TempVal;
		}

		private string[] arrStrings;
	}
}
