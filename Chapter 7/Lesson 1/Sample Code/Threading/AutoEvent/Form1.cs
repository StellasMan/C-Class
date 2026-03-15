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

namespace AutoEvent
{
	public partial class AutoEventForm : Form
	{
		Object m_objLockObject = new Object();
		protected AutoResetEvent m_autoEvent = new AutoResetEvent(false);
		protected ManualResetEvent m_manualEvent = new ManualResetEvent(false);
		protected int m_thrdCount = 0;
		bool m_bSetActive = true;

		public AutoEventForm()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			int threads = (int)nudThreads.Value;
			m_thrdCount += threads;
			txtActive.Text = threads.ToString();

			for (int nIx = 0; nIx < threads; nIx++)
			{
				Thread thrd = new Thread
				(
					() => WaitForEvent()
				);

				thrd.Start();
			}
		}

		private void WaitForEvent()
		{
			Console.WriteLine("Waiting for Auto-Reset event...");
			m_autoEvent.WaitOne();
			Console.WriteLine("Wait for Auto-Reset Complete");

			Console.WriteLine("Waiting for Manual-Reset event...");
			m_manualEvent.WaitOne();
			Console.WriteLine("Wait for Manual-Reset Complete");

			lock (m_objLockObject)
			{
				m_thrdCount--;  // There is no longer a problem here...
			}

			txtActive.Invoke
			(
				new Action(
					() =>
					{
						txtActive.Text = m_thrdCount.ToString();
					}
				)
			);
		}

		private void OnReleaseAuto(object sender, EventArgs e)
		{
			m_autoEvent.Set();	// Set the Auto-Reset Event state to 'Signalled'
		}

		private void OnReleaseManual(object sender, EventArgs e)
		{
			if (m_bSetActive)
			{
				btnManual.Text = "Set\n&Manual";
				m_manualEvent.Set();		// Set the Manual-Reset Event state to 'Signalled'
			}
			else
			{
				btnManual.Text = "Release\n&Manual";
				m_manualEvent.Reset();      // Set the Manual-Reset Event state to 'Non-Signalled'
			}

			m_bSetActive = !m_bSetActive;
		}
	}
}



