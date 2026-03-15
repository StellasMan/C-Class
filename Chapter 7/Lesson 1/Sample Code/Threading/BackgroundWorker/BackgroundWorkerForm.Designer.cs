namespace BkWorkerTest
{
	partial class BkGrndWorkerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_btnStart = new System.Windows.Forms.Button();
			this.m_prgProgress = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.m_btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.m_btnStart.Location = new System.Drawing.Point(159, 116);
			this.m_btnStart.Name = "btnStart";
			this.m_btnStart.Size = new System.Drawing.Size(75, 23);
			this.m_btnStart.TabIndex = 0;
			this.m_btnStart.Text = "&Start";
			this.m_btnStart.UseVisualStyleBackColor = true;
			this.m_btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// prgProgress
			// 
			this.m_prgProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.m_prgProgress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.m_prgProgress.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.m_prgProgress.Location = new System.Drawing.Point(61, 59);
			this.m_prgProgress.Name = "prgProgress";
			this.m_prgProgress.Size = new System.Drawing.Size(363, 23);
			this.m_prgProgress.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(218, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Progress";
			// 
			// btnCancel
			// 
			this.m_btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(251, 116);
			this.m_btnCancel.Name = "btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btnCancel.TabIndex = 3;
			this.m_btnCancel.Text = "&Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			this.m_btnCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// BkGrndWorkerForm
			// 
			this.AcceptButton = this.m_btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(484, 181);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_prgProgress);
			this.Controls.Add(this.m_btnStart);
			this.MinimumSize = new System.Drawing.Size(500, 220);
			this.Name = "BkGrndWorkerForm";
			this.Text = "Background Worker Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnStart;
		private System.Windows.Forms.ProgressBar m_prgProgress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button m_btnCancel;
	}
}

