using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutexDemoUI
{
	public partial class MutexForm : Form
	{
		protected Mutex m_mtxSample = new Mutex(true);
		protected int m_thrdCount = 0;

		public MutexForm()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			int threads = (int)nudThreads.Value;
			m_thrdCount += threads;
			txtActive.Text = threads.ToString();

			for (int nIx=0; nIx<threads; nIx++)
			{
				Thread thrd = new Thread
				(
					() => WaitForMutex()
				);

				thrd.Start();
			}
		}

		private void WaitForMutex()
		{
			Console.WriteLine("Waiting for mutex...");
			m_mtxSample.WaitOne();
			Console.WriteLine("Wait Complete");
			Thread.Sleep(1000);

			m_thrdCount--;
			txtActive.Invoke
			(
				new Action(
					() =>
					{
						txtActive.Text = m_thrdCount.ToString();
					}
				)
			);

			// Make sure to Release the mutex after acquiring the lock or else the 
			// mutex is considered 'Abandoned' will throw an exception.
			Console.WriteLine("Releasing Mutex");
			m_mtxSample.ReleaseMutex();
		}

		private void OnRelease(object sender, EventArgs e)
		{
			m_mtxSample.ReleaseMutex();
		}
	}
}
