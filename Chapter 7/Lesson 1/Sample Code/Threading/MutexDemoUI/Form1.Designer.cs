namespace MutexDemoUI
{
	partial class MutexForm
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
			this.btnStart = new System.Windows.Forms.Button();
			this.nudThreads = new System.Windows.Forms.NumericUpDown();
			this.txtActive = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRelease = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(147, 167);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// nudThreads
			// 
			this.nudThreads.Location = new System.Drawing.Point(155, 101);
			this.nudThreads.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudThreads.Name = "nudThreads";
			this.nudThreads.Size = new System.Drawing.Size(58, 20);
			this.nudThreads.TabIndex = 1;
			this.nudThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtActive
			// 
			this.txtActive.Location = new System.Drawing.Point(264, 101);
			this.txtActive.Name = "txtActive";
			this.txtActive.ReadOnly = true;
			this.txtActive.Size = new System.Drawing.Size(65, 20);
			this.txtActive.TabIndex = 3;
			this.txtActive.Text = "0";
			this.txtActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(161, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Threads";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(278, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Active";
			// 
			// btnRelease
			// 
			this.btnRelease.Location = new System.Drawing.Point(259, 167);
			this.btnRelease.Name = "btnRelease";
			this.btnRelease.Size = new System.Drawing.Size(75, 23);
			this.btnRelease.TabIndex = 5;
			this.btnRelease.Text = "&Release";
			this.btnRelease.UseVisualStyleBackColor = true;
			this.btnRelease.Click += new System.EventHandler(this.OnRelease);
			// 
			// MutexForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 275);
			this.Controls.Add(this.btnRelease);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtActive);
			this.Controls.Add(this.nudThreads);
			this.Controls.Add(this.btnStart);
			this.Name = "MutexForm";
			this.Text = "Mutex Demo";
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.NumericUpDown nudThreads;
		private System.Windows.Forms.TextBox txtActive;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRelease;
	}
}

