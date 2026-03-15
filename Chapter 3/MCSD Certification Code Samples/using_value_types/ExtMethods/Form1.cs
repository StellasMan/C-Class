using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtMethods
{
	public partial class frmExtMethods : Form
	{
		public frmExtMethods()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			int countArr = (int)numCounter.Value;
			int[] arrValues = new int[countArr];
			Random rand = new Random();
			for (int count = 0; count<countArr; count++)
			{
				int randItem = rand.Next(1, 1000);
				arrValues[count] = randItem;
			}

			MessageBox.Show(String.Format("Average: {0:0.00}\nMinimum: {1}\nMaximum: {2}\nStd Deviation: {3:0.00}", 
								arrValues.Average(), 
								arrValues.Min(), 
								arrValues.Max(), 
								arrValues.StdDeviation()));
		}
	}

	public static class ExtMethods
	{
		public static double StdDeviation(this int[] ValuesArray)
		{
			double avgValue = ValuesArray.Average();
			Debug.WriteLine(String.Format("Average value = {0}", avgValue));

			double sumValues = 0;
			int count = 0;
			foreach (int itemVal in ValuesArray)
			{
				double sumItem = Math.Pow(itemVal - avgValue, 2);
				Debug.WriteLine(string.Format("Item {0} value: {1}; Component value: {2}", ++count, itemVal, sumItem));
				sumValues += sumItem;
			}

			return Math.Sqrt(sumValues/ValuesArray.GetLength(0));
		}
	}
}
