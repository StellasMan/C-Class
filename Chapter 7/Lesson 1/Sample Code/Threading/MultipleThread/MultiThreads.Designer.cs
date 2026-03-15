namespace ThreadPool
{
	partial class MultiThreadingForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.nudDuration = new System.Windows.Forms.NumericUpDown();
			this.nudThreads = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(101, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Duration";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(153, 126);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(211, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Number of Threads";
			// 
			// nudDuration
			// 
			this.nudDuration.Location = new System.Drawing.Point(95, 77);
			this.nudDuration.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudDuration.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudDuration.Name = "nudDuration";
			this.nudDuration.Size = new System.Drawing.Size(59, 20);
			this.nudDuration.TabIndex = 5;
			this.nudDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudDuration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// nudThreads
			// 
			this.nudThreads.Location = new System.Drawing.Point(214, 77);
			this.nudThreads.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudThreads.Name = "nudThreads";
			this.nudThreads.Size = new System.Drawing.Size(59, 20);
			this.nudThreads.TabIndex = 6;
			this.nudThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudThreads.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// MultiThreadingForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 211);
			this.Controls.Add(this.nudThreads);
			this.Controls.Add(this.nudDuration);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnStart);
			this.Name = "MultiThreadingForm";
			this.Text = "Multiple Threads";
			this.Load += new System.EventHandler(this.OnThreadingFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudDuration;
		private System.Windows.Forms.NumericUpDown nudThreads;
	}
}

