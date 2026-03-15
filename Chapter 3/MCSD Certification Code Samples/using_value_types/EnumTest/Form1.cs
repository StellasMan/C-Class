using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumTest
{
	public partial class frmEnumTest : Form
	{
		public enum Months : byte { January=1, February, March, April, May, June, July, August, September, October, November, December };

		public frmEnumTest()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			Months monTest = Months.January;
			MessageBox.Show("Current month is " + monTest.ToString());

			//monTest--;			// OK
			//monTest += 255;		// OK
			//monTest += 256;		// Error - cannot add int value to byte

			for (int indx = 0; indx < 15; indx++)
			{
				monTest++;
				MessageBox.Show("Current month is " + monTest.ToString());

				if (monTest == Months.December)
					break;
			}

			int monNumber = 1;

			// typeof(XYZ) returns a System.Type instance which contains all
			// the information about the variable TYPE 'XYZ'
			foreach(string monthName in System.Enum.GetNames(typeof(Months)))
			{
				MessageBox.Show("Month " + monNumber++ + " is " + monthName); 
			}
		}
	}
}
