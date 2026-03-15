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

namespace ThreadPool
{
	public partial class MultiThreadingForm : Form
	{
		public MultiThreadingForm()
		{
			InitializeComponent();
		}

		private void OnThreadingFormLoad(object sender, EventArgs e)
		{
			nudDuration.Value = 10;
			nudThreads.Value = 8;

			btnStart.Focus();
		}

		private void ThreadMethod(Object obj)
		{
			SenselessLoop(obj);
		}

		private void ThreadWParameter(Object obj)
		{
			SenselessLoop(obj);
		}

		private void OnStart(object sender, EventArgs e)
		{
			int nDuration = (int)nudDuration.Value;
			int nThreads = (int)nudThreads.Value;
			for (int nIx = 0; nIx < nThreads; nIx++)
			{
				object[] objParam = new object[] { nDuration, nIx + 1 };

				//Thread thread = new Thread(ThreadWParameter);

				Thread thread = new Thread
				(
					(Object obj) => SenselessLoop(obj)
				);
				thread.Start(objParam);
			}
		}

		private void SenselessLoop(Object objState)
		{
			Stopwatch sw = Stopwatch.StartNew();

			Object[] aParams = objState as Object[];
			Int32 nSeconds = (Int32)aParams[0];
			Int32 nThreadID = (Int32)aParams[1];

			int nMilliseconds = nSeconds * 1000;

			Console.WriteLine($"Thread {nThreadID}: Starting loop - Waiting for {nSeconds} seconds");

			while (sw.ElapsedMilliseconds < nMilliseconds)
			{
				int nCounter = 0;
				for (int nIx = 0; nIx < int.MaxValue / 10; nIx++)
				{
					nCounter++;
				}
			}

			Console.WriteLine($"Thread {nThreadID}: Complete after {sw.ElapsedMilliseconds / 1000.0:f3} seconds have elapsed");

			sw.Stop();
		}
	}
}


//Thread thread = new Thread
//	(
//		(Object obj) =>
//		{
//			SenselessLoop(obj);
//		}
//	);

