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
	public partial class SimpleThreadingForm : Form
	{
		private Thread m_SimpleThread = null;

		public SimpleThreadingForm()
		{
			InitializeComponent();
		}

		private void OnThreadingFormLoad(object sender, EventArgs e)
		{
			txtDuration.Text = "10";

			btnStart.Focus();
		}

		private void BasicParameterizedThread(Object obj)
		{
			int nSeconds = 15;
			if (obj.GetType() == typeof(int))
				nSeconds = (int)obj;

			SenselessLoop(nSeconds);
		}

		private void BasicThread()
		{
			string sThreadType = System.Threading.Thread.CurrentThread.IsBackground ? "Background" : "Foreground";
			Console.WriteLine($"Starting {sThreadType} thread");
			SenselessLoop(15);
		}

		//private void OnStart(object sender, EventArgs e)
		//{
		//	btnStart.Enabled = false;

		//	m_SimpleThread = new Thread(BasicThread);
		//	m_SimpleThread.IsBackground = false;

		//	m_SimpleThread.Start();
		//}

		private void OnStart(object sender, EventArgs e)
		{
			int nDuration = 0;
			if (int.TryParse(txtDuration.Text, out nDuration))
			{
				btnStart.Enabled = false;
				m_SimpleThread = new Thread(BasicParameterizedThread);
				m_SimpleThread.Priority = ThreadPriority.Highest;
				m_SimpleThread.IsBackground = true;
				m_SimpleThread.Start(nDuration);
			}
		}

		//private void OnStart(object sender, EventArgs e)
		//{
		//	int nDuration = 0;
		//	if (int.TryParse(txtDuration.Text, out nDuration))
		//	{
		//     m_SimpleThread = new Thread
		//			(() => SenselessLoop(nDuration));
		//
		//		m_SimpleThread.Start();
		//	}
		//}

		private void EnableStart()
		{
			btnStart.Enabled=true;
		}

		private void SenselessLoop(int nSeconds)
		{
			Stopwatch sw = Stopwatch.StartNew();

			int nMilliseconds = nSeconds * 1000;

			while (sw.ElapsedMilliseconds < nMilliseconds)
			{
				int nCounter = 0;
				for (int nIx = 0; nIx < int.MaxValue / 10; nIx++)
				{
					nCounter++;
				}
				Console.WriteLine($"Loop Progress: {sw.ElapsedMilliseconds / 1000.0:f3} seconds have elapsed");
			}

			Console.WriteLine($"Complete after {sw.ElapsedMilliseconds / 1000.0:f3} seconds have elapsed");

			sw.Stop();

			m_SimpleThread = null;

			btnStart.Invoke
				(
					new Action(() => btnStart.Enabled = true)
				);

			// btnStart.Enabled=true;

			//Action action = EnableStart;
			//btnStart.Invoke(action);

			//btnStart.Invoke(new Action(EnableStart));
		}

		private void OnWait(object sender, EventArgs e)
		{
			if (m_SimpleThread != null)
				m_SimpleThread.Join();
		}
	}
}
