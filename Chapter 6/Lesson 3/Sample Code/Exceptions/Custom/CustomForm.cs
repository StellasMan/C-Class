using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom
{
	public partial class CustomForm : Form
	{
		public CustomForm()
		{
			InitializeComponent();
			txtDividend.Clear();
			txtDivisor.Clear();
			txtResult.Clear();
		}

		private decimal DecimalFunc(int Val1, int Val2)
		{
			return ((decimal)Val1) / ((decimal)Val2);
		}

		public decimal FuncDivide(int x, int y)
		{
			//checked
			//{
			//	int nValue1 = int.MaxValue;
			//	int Overflow = nValue1 * nValue1;
			//}

			decimal retValue = 0.0m;

			try
			{
				retValue = ((decimal)x / y);
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine($"Caught a Divide by Zero Exception\n{ex.Message}\n{ex.StackTrace}");

				System.Reflection.MethodInfo preserveStackTrace = typeof(Exception).GetMethod("InternalPreserveStackTrace", 
						System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
				preserveStackTrace.Invoke(ex, null);
				throw ex;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Caught a general Exception\n{ex.Message}\n{ex.StackTrace}");
				throw;
			}
			finally
			{
				Console.WriteLine("funcDivide 'finally' execution");
			}

			return retValue;
		}

		private void OnGo(object sender, EventArgs e)
		{
			txtResult.Clear();

			string sDividend = txtDividend.Text;
			string sDivisor = txtDivisor.Text;

			int Dividend, Divisor;
			decimal Result = 0.0m;

			if (int.TryParse(sDividend, out Dividend))
			{
				if (int.TryParse(sDivisor, out Divisor))
				{
					try
					{
						Result = FuncDivide(Dividend, Divisor);
					}
					catch (DivideByZeroException ex)
					{
						Console.WriteLine(ex.Message);
						Console.WriteLine(ex.StackTrace);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
						Console.WriteLine(ex.StackTrace);
					}
					finally
					{
						txtResult.Text = $"{Result:#,##0.00}";
					}
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
