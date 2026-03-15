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

namespace Types
{
	enum Season
	{
		Spring,
		Summer,
		Autumn,
		Winter
	};

	public partial class TypesForm : Form
	{
		public TypesForm()
		{
			InitializeComponent();
		}

		private void OnStartClick(object sender, EventArgs e)
		{
			Season sTest = Season.Autumn;
			int SeasonNumber = (int)sTest;

			txtSeason.Text =	"The current season is " + 
								sTest + 
								Environment.NewLine + 
								"which is season " + 
								SeasonNumber;

			int[] Test = { 1, 2, 3, 4 };
			Test[0] = 2 * Test[1];

			MessageBox.Show("Test[0] = " + Test[0]);
		}
	}
}
