namespace ExtMethods
{
	partial class frmExtMethods
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
			this.numCounter = new System.Windows.Forms.NumericUpDown();
			this.btnStart = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numCounter)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(96, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Elements in Array:";
			// 
			// numCounter
			// 
			this.numCounter.Location = new System.Drawing.Point(202, 75);
			this.numCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numCounter.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numCounter.Name = "numCounter";
			this.numCounter.Size = new System.Drawing.Size(87, 20);
			this.numCounter.TabIndex = 1;
			this.numCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numCounter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(157, 149);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// frmExtMethods
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 211);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.numCounter);
			this.Controls.Add(this.label1);
			this.Name = "frmExtMethods";
			this.Text = "Extension Methods";
			((System.ComponentModel.ISupportInitialize)(this.numCounter)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numCounter;
		private System.Windows.Forms.Button btnStart;
	}
}

