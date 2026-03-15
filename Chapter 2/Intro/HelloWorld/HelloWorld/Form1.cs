using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace HelloWorld
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void OnComputeClick(object sender, EventArgs e)
		{
			String szArg1 = txtNumber1.Text;
			String szArg2 = txtNumber2.Text;

			int nArg1, nArg2;
			if (System.Int32.TryParse(szArg1, out nArg1) && System.Int32.TryParse(szArg2, out nArg2))
			{
				int nSum = (nArg1 + nArg2);
				int nProduct = (nArg1 * nArg2);

				String sResult = String.Format("Sum of {0} and {1} is {2};\nProduct of {0} and {1} is {3}", nArg1, nArg2, nSum, nProduct);
				if (DialogResult.Yes == MessageBox.Show(sResult, "Is this the answer?", MessageBoxButtons.YesNo))
				{
					MessageBox.Show("That's right!");
				}
				else
				{
					MessageBox.Show("Hmmm... Someone wasn't listening in math class!");
				}
			}
			else
			{
				MessageBox.Show("Failed to Parse!");
				Console.Beep(1000, 500);
			}
		}
	}
}
