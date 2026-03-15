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
	public partial class ThreadMethodsForm : Form
	{
		private LinkedList<Thread> m_lstThreads = new LinkedList<Thread>();
		private readonly object m_threadLock = new object();
		private uint m_uiSleepCount = 0;
		private uint m_uiSuspendCount = 0;

		public ThreadMethodsForm()
		{
			InitializeComponent();
		}

		private void OnThreadingFormLoad(object sender, EventArgs e)
		{
			nudDuration.Value = 15;
			nudThreads.Value = 8;

			btnStart.Focus();
		}

		private void OnStart(object sender, EventArgs e)
		{
			m_lstThreads.Clear();

			int nDuration = (int)nudDuration.Value;
			int nThreads = (int)nudThreads.Value;
			for (int nIx = 0; nIx < nThreads; nIx++)
			{
				Thread thread = new Thread
					(() => SenselessLoop(nDuration));

				m_lstThreads.AddLast(thread);
			}

			foreach (Thread threadItem in m_lstThreads)
				threadItem.Start();
		}

		private void SenselessLoop(int nSeconds)
		{
			Stopwatch sw = Stopwatch.StartNew();

			int nMilliseconds = nSeconds * 1000;

			Console.WriteLine($"Starting loop - Waiting for {nSeconds} seconds");

			try
			{
				while (sw.ElapsedMilliseconds < nMilliseconds)
				{
					int nCounter = 0;
					for (int nIx = 0; nIx < int.MaxValue / 10; nIx++)
					{
						nCounter++;
					}

					Console.WriteLine($"Progress: {sw.ElapsedMilliseconds / 1000.0:f3} seconds have elapsed");

					bool bSleep = false;
					bool bSuspend = false;
					lock (m_threadLock)
					{
						if (m_uiSleepCount > 0)
						{
							m_uiSleepCount--;
							bSleep = true;
						}
						else if (m_uiSuspendCount > 0)
						{
							m_uiSuspendCount--;
							bSuspend = true;
						}
					}

					if (bSleep)
					{
						sw.Stop();
						System.Threading.Thread.Sleep(5000);
						bSleep = false;
						sw.Start();
					}

					if (bSuspend)
					{
						sw.Stop();
						Thread currentThread = Thread.CurrentThread;
						currentThread.Suspend();
						bSuspend = false;
						sw.Start();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("Clean up any thread resources");
			}

			Console.WriteLine($"Complete after {sw.ElapsedMilliseconds / 1000.0:f3} seconds have elapsed");

			sw.Stop();
		}

		private void OnSleep(object sender, EventArgs e)
		{
			lock(m_threadLock)
			{
				if ((m_lstThreads.Count > 0) && (m_uiSleepCount == 0))
					m_uiSleepCount = (uint)m_lstThreads.Count;
			}
		}

		private void OnSuspend(object sender, EventArgs e)
		{
			lock (m_threadLock)
			{
				if ((m_lstThreads.Count > 0) && (m_uiSleepCount == 0))
					m_uiSuspendCount = (uint)m_lstThreads.Count;
			}
		}

		private void OnResume(object sender, EventArgs e)
		{
			if ((m_lstThreads.Count > 0) && (m_uiSleepCount == 0))
			{
				foreach (Thread threadItem in m_lstThreads)
				{
					threadItem.Resume();
				}
			}
		}

		private void OnAbort(object sender, EventArgs e)
		{
			foreach (Thread threadItem in m_lstThreads)
				threadItem.Abort();
		}
	}
}
