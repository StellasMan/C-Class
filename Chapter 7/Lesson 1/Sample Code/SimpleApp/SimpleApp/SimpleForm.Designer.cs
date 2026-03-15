namespace SimpleApp
{
	partial class SimpleForm
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
			this.nudDelay = new System.Windows.Forms.NumericUpDown();
			this.lblDelay = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(146, 138);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(87, 27);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// nudDelay
			// 
			this.nudDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nudDelay.Location = new System.Drawing.Point(250, 140);
			this.nudDelay.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudDelay.Name = "nudDelay";
			this.nudDelay.Size = new System.Drawing.Size(82, 22);
			this.nudDelay.TabIndex = 2;
			this.nudDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// lblDelay
			// 
			this.lblDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDelay.Location = new System.Drawing.Point(242, 108);
			this.lblDelay.Name = "lblDelay";
			this.lblDelay.Size = new System.Drawing.Size(96, 30);
			this.lblDelay.TabIndex = 1;
			this.lblDelay.Text = "&Delay\r\n (in Seconds)";
			this.lblDelay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// SimpleForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 272);
			this.Controls.Add(this.lblDelay);
			this.Controls.Add(this.nudDelay);
			this.Controls.Add(this.btnStart);
			this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximumSize = new System.Drawing.Size(1000, 622);
			this.MinimumSize = new System.Drawing.Size(500, 311);
			this.Name = "SimpleForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Simple";
			((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.NumericUpDown nudDelay;
		private System.Windows.Forms.Label lblDelay;
	}
}

