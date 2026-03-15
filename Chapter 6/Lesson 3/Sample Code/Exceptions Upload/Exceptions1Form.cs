using System;
using System.Windows.Forms;

namespace Exceptions
{
	public partial class Exceptions1Form : Form
	{
		public delegate decimal TestDelegate(int Val1, int Val2);
		static int m_Count = 0;

		public Exceptions1Form()
		{
			InitializeComponent();
			txtDividend.Clear();
			txtDivisor.Clear();
			txtResult.Clear();
		}

		private decimal TestFunc(int Val1, int Val2)
		{
			return ((decimal)Val1 / Val2);
		}

		private decimal TestFunc2(int Val1, int Val2)
		{
			// C# does not check for overflow by default.
			// Putting code inside a 'checked' block enables C#
			// overflow testing after arithmetic operations.
			checked
			{
				return (int.MaxValue * (Val1 + Val2));
			}
		}

		private void OnGo(object sender, EventArgs e)
		{

			txtResult.Clear();

			string sParam1 = txtDividend.Text;
			string sParam2 = txtDivisor.Text;

			Func<int, int, decimal> funcTest = TestFunc;

			// Throw an overflow exception every 3rd time
			// the user presses the 'Go' button.
			if ((++m_Count % 3) == 0)
				funcTest += TestFunc2;

			int nParam1, nParam2;
			decimal Result = 0.0m;

			if (int.TryParse(sParam1, out nParam1))
			{
				if (int.TryParse(sParam2, out nParam2))
				{
					Result = funcTest(nParam1, nParam2);
					txtResult.Text = $"{Result:#,###.0000}";
				}
				else
				{
					MessageBox.Show("Invalid Divisor", "Warning");
					txtDivisor.Clear();
					txtDivisor.Focus();
				}
			}
			else
			{
				MessageBox.Show("Invalid Dividend", "Warning");
				txtDividend.Clear();
				txtDividend.Focus();
			}
		}
	}
}


















/*
					try
					{
						Result = funcTest(nParam1, nParam2);
					}
					catch (DivideByZeroException ex)
					{
						Console.WriteLine("Divide by Zero Exception");
						Console.WriteLine(ex.Message);
						Console.WriteLine(ex.StackTrace);
					}
					catch (Exception ex)
					{
						Console.WriteLine("General Exception");
						Console.WriteLine(ex.Message);
						Console.WriteLine(ex.StackTrace);
					}
					finally
					{
						txtResult.Text = $"{Result:#,##0.00}";
					}
*/
