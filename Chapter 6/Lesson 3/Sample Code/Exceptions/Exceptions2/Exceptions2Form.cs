using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptions
{
	public partial class Exceptions2Form : Form
	{
		public Exceptions2Form()
		{
			InitializeComponent();
		}

		private void NullReference(object nullObject)
		{
			Console.WriteLine(nullObject.ToString());
		}

		private decimal DoDivideLevel2(int Dividend, int Divisor)
		{
			decimal Result  = 0;

			try
			{
				Console.WriteLine("DoDivideLevel2::'Before DivideByZero exception is thrown");
				Result = Dividend / Divisor;
				Console.WriteLine("DoDivideLevel2::'After DivideByZero exception is thrown");

				NullReference(null);	// Throws a 'NullReferenceException
			}
			catch (NotFiniteNumberException ex)
			{
				Console.WriteLine($"'DoDivideLevel2': Catch NotFiniteNumberException: - {ex.Message}");
			}
			finally
			{
				Console.WriteLine("DoDivideLevel2::'finally' section");
			}

			return Result;
		}

		private decimal DoDivideLevel1(int Dividend, int Divisor)
		{
			decimal Result = 0;

			try
			{
				//if (Divisor == 0)
				//	throw new ArgumentException("DoDivideLevel1: Divisor cannot be 0");

				Console.WriteLine("DoDivideLevel1::'Before DivideByZero exception is thrown");
				DoDivideLevel2(Dividend, Divisor);
				Console.WriteLine("DoDivideLevel1::'After DivideByZero exception is thrown");
			}
			catch (OverflowException ex)
			{
				Console.WriteLine($"'DoDivideLevel1': Catch OverflowException: - {ex.Message}");
			}
			finally
			{
				Console.WriteLine("DoDivideLevel1::'finally' section");
			}

			return Result;
		}

		private void OnGo(object sender, EventArgs e)
		{
			txtResult.Clear();

			string sDividend = txtDividend.Text;
			string sDivisor = txtDivisor.Text;

			// *******************************************************
			// Anonymous function using lambda expression syntax
			Func<int, int, decimal> funcDivide = (x, y) =>
			{
				return DoDivideLevel1(x, y);
			};
			// *******************************************************

			int Dividend, Divisor;
			decimal Result = 0.0m;

			if (int.TryParse(sDividend, out Dividend))
			{
				if (int.TryParse(sDivisor, out Divisor))
				{
					try
					{
						Result = funcDivide(Dividend, Divisor);	// Invoke anonymous method
					}
					catch (DivideByZeroException ex)
					{
						Console.WriteLine($"'OnGo': Catch DivideByZeroException: - {ex.Message}");
						Console.WriteLine(ex.StackTrace);
					}
					catch (NullReferenceException ex)
					{
						Console.WriteLine($"'OnGo': Catch NullReferenceException: - {ex.Message}");
						Console.WriteLine(ex.StackTrace);
					}
					catch (Exception ex)
					{
						Console.WriteLine($"'OnGo': Catch Exception: - {ex.Message}");
						Console.WriteLine(ex.StackTrace);
					}
					finally
					{
						Console.WriteLine("OnGo::'finally' section");
						txtResult.Text = $"{Result:#,###.00}";
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
