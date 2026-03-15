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

namespace NoThreading
{
	public partial class NoThreadingForm : Form
	{
		public NoThreadingForm()
		{
			InitializeComponent();
			txtDuration.Text = "10";
		}

		private void OnStart(object sender, EventArgs e)
		{
			string szDuration = txtDuration.Text;
			int nDuration = 0;
			if (int.TryParse(szDuration, out nDuration))
			{
				btnStart.Enabled = false;
				SenselessLoop(nDuration);
			}
		}

		private void SenselessLoop(int nSeconds)
		{
			Stopwatch sw  = Stopwatch.StartNew();

			int nMilliseconds = nSeconds * 1000;

			while (sw.ElapsedMilliseconds < nMilliseconds)
			{
				int nCounter = 0;
				Console.WriteLine("Entering inner loop");
				for (int nIx=0; nIx<int.MaxValue/100; nIx++)
				{
					nCounter++;
				}

				Console.WriteLine($"Exiting inner loop - {sw.ElapsedMilliseconds/1000.0:f3} seconds have elapsed");
			}
			
			sw.Stop();
			btnStart.Enabled = true;
		}
	}
}
