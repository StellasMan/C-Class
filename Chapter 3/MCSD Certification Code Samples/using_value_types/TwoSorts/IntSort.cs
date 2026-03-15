using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSorts
{
	public class IntSort
	{
		public IntSort(int[] IntArray)
		{
			arrInts = IntArray;
		}

		public int[] Sort()
		{
			// Sorting - Integer sort
			for (int i=0; i< arrInts.Length; i++)
			{
				for (int j=i+1; j<arrInts.Length; j++)
				{
					if (arrInts[i] > arrInts[j])
					{
						IntSwap(ref arrInts[i], ref arrInts[j]);
					}
				}
			}

			return arrInts;
		}

		private void IntSwap(ref int IntVal1, ref int IntVal2)
		{
			int TempVal = IntVal1;
			IntVal1 = IntVal2;
			IntVal2 = TempVal;
		}

		private int[] arrInts;
	}
}
