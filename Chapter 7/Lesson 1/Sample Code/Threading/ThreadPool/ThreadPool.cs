using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace ThreadPoolExample
{
	public partial class ThreadPoolForm : Form
	{
		public ThreadPoolForm()
		{
			InitializeComponent();
		}

		private void OnThreadingFormLoad(object sender, EventArgs e)
		{
			nudDuration.Value = 10;
			nudThreads.Value = 8;

			int nWorkerThreads;
			int nCompletionPortThreads;

			ThreadPool.GetMaxThreads(out nWorkerThreads, out nCompletionPortThreads);
			txtMax.Text = nWorkerThreads.ToString();

			ShowAvailable();

			btnStart.Focus();
		}

		private void ShowAvailable()
		{
			int nWorkerThreads;
			int nCompletionPortThreads;

			ThreadPool.GetAvailableThreads(out nWorkerThreads, out nCompletionPortThreads);

			if (txtAvailable.InvokeRequired)
			{
				txtAvailable.Invoke
				(
					new Action
					(
						() =>
						{
							nWorkerThreads++;
							txtAvailable.Text = nWorkerThreads.ToString();
						}
					)
				);
			}
			else
			{
				txtAvailable.Text = nWorkerThreads.ToString();
			}
		}

		void BackgroundThreadProc(Object stateInfo)
		{
			Console.WriteLine("Hello from the thread pool.");

			int nSeconds = 15;
			if (stateInfo.GetType() == typeof(int))
				nSeconds = (int)stateInfo;

			SenselessLoop(nSeconds);
		}

		private void OnStart(object sender, EventArgs e)
		{
			// Start the background threads
			for (int nIx=0; nIx<nudThreads.Value; nIx++)
			{
				ThreadPool.QueueUserWorkItem(BackgroundThreadProc, (int)nudDuration.Value);
			}

			ShowAvailable();
		}

		private void SenselessLoop(int nSeconds)
		{
			Stopwatch sw = Stopwatch.StartNew();

			int nMilliseconds = nSeconds * 1000;

			Console.WriteLine($"Starting loop - Waiting for {nSeconds} seconds");

			while (sw.ElapsedMilliseconds < nMilliseconds)
			{
				int nCounter = 0;
				for (int nIx = 0; nIx < int.MaxValue / 10; nIx++)
				{
					nCounter++;
				}
			}

			Console.WriteLine($"Complete after {sw.ElapsedMilliseconds / 1000.0:f3} seconds have elapsed");

			sw.Stop();

			ShowAvailable();
		}
	}
}
