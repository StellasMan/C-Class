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

namespace BkWorkerTest
{
	public partial class BkGrndWorkerForm : Form
	{
		private BackgroundWorker m_bkWorker;

		public BkGrndWorkerForm()
		{
			InitializeComponent();

			m_bkWorker = new BackgroundWorker();

			m_bkWorker.WorkerReportsProgress = true;
			m_bkWorker.WorkerSupportsCancellation = true;

			m_bkWorker.DoWork += BkWorkerThread;
			m_bkWorker.ProgressChanged += BkWorkerProgressChanged;
			m_bkWorker.RunWorkerCompleted += BkWorkerCompleted;

			m_prgProgress.Minimum = 0;
			m_prgProgress.Maximum = 1000;
			m_prgProgress.Style = ProgressBarStyle.Continuous;

			m_btnCancel.Enabled = false;
		}

		private void OnStart(Object sender, EventArgs e)
		{
			m_btnCancel.Enabled = true;
			m_btnStart.Enabled = false;

			m_bkWorker.RunWorkerAsync();
		}

		private void OnCancel(Object sender, EventArgs e)
		{
			if (!m_bkWorker.CancellationPending)
				m_bkWorker.CancelAsync();
		}

		private void BkWorkerThread(Object objSender, DoWorkEventArgs eArgs)
		{
			BackgroundWorker bkWorker = objSender as BackgroundWorker;
			if (bkWorker != null)
			{
				for (int nIx = 0; nIx < 1000; nIx++)
				{
					System.Threading.Thread.Sleep(10);
					bkWorker.ReportProgress(nIx+1);

					if (bkWorker.CancellationPending)
					{
						eArgs.Cancel = true;
						break;
					}
				}
			}
		}

		private void BkWorkerProgressChanged(Object objSender, ProgressChangedEventArgs pceArgs)
		{
			m_prgProgress.Value = pceArgs.ProgressPercentage;
			m_prgProgress.Text = String.Format("{0} percent complete", pceArgs.ProgressPercentage/10);
		}

		private void BkWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
		{
			m_btnCancel.Enabled = false;
			m_btnStart.Enabled = true;
			System.Diagnostics.Trace.WriteLine(String.Format("BkWorker {0}", e.Cancelled ? "Cancelled" : "Completed"));

			if (e.Cancelled)
			{
				m_prgProgress.Value = 0;
				m_prgProgress.Text = "0 percent complete";
			}
		}
	}
}
