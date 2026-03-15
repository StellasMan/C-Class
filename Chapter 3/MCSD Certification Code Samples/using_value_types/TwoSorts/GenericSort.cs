using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSorts
{
	public delegate int CompareFunc<in T>(T x, T y);
	public class GenericSort<T>
	{

		public GenericSort(T[] ValuesArray)
		{
			arrValues = ValuesArray;
		}

		public T[] Sort(CompareFunc<T> compFunc)
		{
			// Sorting - Generic sort
			for (int i = 0; i < arrValues.Length; i++)
			{
				for (int j = i + 1; j < arrValues.Length; j++)
				{
					if (compFunc(arrValues[i], arrValues[j]) > 0)
					{
						ValueSwap(ref arrValues[i], ref arrValues[j]);
					}
				}
			}

			return arrValues;
		}

		private void ValueSwap(ref T IntVal1, ref T IntVal2)
		{
			T TempVal = IntVal1;
			IntVal1 = IntVal2;
			IntVal2 = TempVal;
		}

		private T[] arrValues;
	}
}
