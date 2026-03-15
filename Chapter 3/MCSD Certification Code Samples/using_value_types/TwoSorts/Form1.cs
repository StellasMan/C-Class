using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoSorts
{
	public partial class frmTwoSorts : Form
	{
		private string Melville =
			"Call me Ishmael. Some years ago never mind how long precisely, having " +
			"little or no money in my purse and nothing particular to interest me " +
			"on shore, I thought I would sail about a little and see the watery part " +
			"of the world. It is a way I have of driving off the spleen and regulating " +
			"the circulation. Whenever I find myself growing grim about the mouth; " +
			"whenever it is a damp drizzly November in my soul, whenever I find myself " +
			"involuntarily pausing before coffin warehouses and bringing up the rear " + 
			"of every funeral I meet; and especially whenever my hypos get such an " +
			"upper hand of me, that it requires a strong moral principle to prevent me " +
			"from deliberately stepping into the street and methodically knocking people’s " +
			"hats off, then I account it high time to get to sea as soon as I can.";

		private int[] intArray = new int[100];
		private string[] strArray;

		public frmTwoSorts()
		{
			InitializeComponent();
		}

		// Populate arrays and display
		private void OnStart(object sender, EventArgs e)
		{
			// Create an array from random numbers between 1 and 1000
			Random rand = new Random();
			for (int count=0; count < intArray.GetLength(0); count++)
			{
				intArray[count] = rand.Next(1, 1000);
			}

			char[] charDelims = new char[]{ ' ', '.', ',' };
			strArray = Melville.Split(new char[]{ ' ', '.', ',', ';' });

			lstIntegers.Items.Clear();
			for (int count = 0; count < intArray.GetLength(0); count++)
			{
				lstIntegers.Items.Add(intArray[count].ToString());
			}

			lstStrings.Items.Clear();
			for (int count = 0; count < strArray.GetLength(0); count++)
			{
				string strItem = strArray[count].Trim();
				if (strItem.Length > 0)
					lstStrings.Items.Add(strArray[count]);
			}

			btnSort.Enabled = true;
			btnGeneric.Enabled = true;
		}

		// Sort arrays with type-specific Sort and display
		private void OnSort(object sender, EventArgs e)
		{
			// Sort the integer array
			IntSort intSort = new IntSort(intArray);
			intSort.Sort();

			lstIntegers.Items.Clear();
			for (int count = 0; count < intArray.GetLength(0); count++)
			{
				lstIntegers.Items.Add(intArray[count].ToString());
			}

			StringSort strSort = new StringSort(strArray);
			strSort.Sort();

			lstStrings.Items.Clear();
			for (int count = 0; count < strArray.GetLength(0); count++)
			{
				string strItem = strArray[count].Trim();
				if (strItem.Length > 0)
					lstStrings.Items.Add(strArray[count]);
			}
		}

		// Compare function for integers
		private static int CompareInts(int x, int y)
		{
			if (x > y)
				return 1;
			else if (x < y)
				return -1;
			else
				return 0;
		}

		// Compare function for strings
		private static int CompareStrings(string x, string y)
		{
			return x.CompareTo(y);
		}

		// Sort arrays with generic sort method and display
		private void OnGeneric(object sender, EventArgs e)
		{
			CompareFunc<int> compareFunc = CompareInts;
			CompareFunc<string> compareString = CompareStrings;

			// Sort the integer array
			GenericSort<int> intSort = new GenericSort<int>(intArray);
			intSort.Sort(compareFunc);

			lstIntegers.Items.Clear();
			for (int count = 0; count < intArray.GetLength(0); count++)
			{
				lstIntegers.Items.Add(intArray[count].ToString());
			}

			GenericSort<string> strSort = new GenericSort<string>(strArray);
			strSort.Sort(compareString);

			lstStrings.Items.Clear();
			for (int count = 0; count < strArray.GetLength(0); count++)
			{
				string strItem = strArray[count].Trim();
				if (strItem.Length > 0)
					lstStrings.Items.Add(strArray[count]);
			}
		}
	}
}
