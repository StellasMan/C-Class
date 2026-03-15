using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleApp
{
	public partial class SimpleForm : Form
	{
		public SimpleForm()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			int seconds = (int)nudDelay.Value;
			Thread thread = new Thread
			(() => 
				{ 
					DoDelay(seconds);
				}
			);

			btnStart.Enabled = false;
			nudDelay.Enabled = false;
			thread.Start();
		}

		private void DoDelay(int nSeconds)
		{
			Stopwatch sw = Stopwatch.StartNew();

			int nMilliseconds = nSeconds * 1000;

			while (sw.ElapsedMilliseconds < nMilliseconds)
			{
				int nCounter = 0;
				for (int nIx = 0; nIx < int.MaxValue / 100; nIx++)
				{
					nCounter++;
				}

				Console.WriteLine($"{sw.ElapsedMilliseconds / 1000.0:f3} seconds have elapsed");
			}

			sw.Stop();
			btnStart.Invoke
			(new Action(() =>
				{
					btnStart.Enabled = true;
					nudDelay.Enabled = true;
				}
			));
		}
	}
}
