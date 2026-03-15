namespace AutoEvent
{
	partial class AutoEventForm
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
			this.btnAuto = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtActive = new System.Windows.Forms.TextBox();
			this.nudThreads = new System.Windows.Forms.NumericUpDown();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnManual = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAuto
			// 
			this.btnAuto.Location = new System.Drawing.Point(149, 141);
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Size = new System.Drawing.Size(75, 40);
			this.btnAuto.TabIndex = 11;
			this.btnAuto.Text = "&Release Auto";
			this.btnAuto.UseVisualStyleBackColor = true;
			this.btnAuto.Click += new System.EventHandler(this.OnReleaseAuto);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(280, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "&Active";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(163, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "&Threads";
			// 
			// txtActive
			// 
			this.txtActive.Location = new System.Drawing.Point(266, 101);
			this.txtActive.Name = "txtActive";
			this.txtActive.ReadOnly = true;
			this.txtActive.Size = new System.Drawing.Size(65, 20);
			this.txtActive.TabIndex = 9;
			this.txtActive.Text = "0";
			this.txtActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nudThreads
			// 
			this.nudThreads.Location = new System.Drawing.Point(157, 101);
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
			this.nudThreads.TabIndex = 7;
			this.nudThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(205, 219);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 10;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// btnManual
			// 
			this.btnManual.Location = new System.Drawing.Point(261, 141);
			this.btnManual.Name = "btnManual";
			this.btnManual.Size = new System.Drawing.Size(75, 40);
			this.btnManual.TabIndex = 12;
			this.btnManual.Text = "Release &Manual";
			this.btnManual.UseVisualStyleBackColor = true;
			this.btnManual.Click += new System.EventHandler(this.OnReleaseManual);
			// 
			// AutoEventForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 275);
			this.Controls.Add(this.btnManual);
			this.Controls.Add(this.btnAuto);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtActive);
			this.Controls.Add(this.nudThreads);
			this.Controls.Add(this.btnStart);
			this.MinimumSize = new System.Drawing.Size(500, 314);
			this.Name = "AutoEventForm";
			this.Text = "Auto Reset Event";
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAuto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtActive;
		private System.Windows.Forms.NumericUpDown nudThreads;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnManual;
	}
}

