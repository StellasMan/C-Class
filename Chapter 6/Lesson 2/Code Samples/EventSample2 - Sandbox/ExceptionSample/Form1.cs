using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionSample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private double Divide(int nVar1, int nVar2)
		{
			double dResult = 0;
			try
			{
				dResult = nVar1 / nVar2;
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
				dResult = 0;

				throw;
			}
			finally
			{
				Console.WriteLine("This section is always executed");
			}

			return dResult;
		}

		private void OnGo(object sender, EventArgs e)
		{
			double dResult = Divide(100, 0);
			Console.WriteLine($"Result of division is {dResult:F2}");
		}
	}
}
