namespace ThreadPool
{
	partial class SimpleThreadingForm
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
			this.txtDuration = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnWait = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(169, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Duration";
			// 
			// txtDuration
			// 
			this.txtDuration.Location = new System.Drawing.Point(142, 79);
			this.txtDuration.Name = "txtDuration";
			this.txtDuration.Size = new System.Drawing.Size(100, 20);
			this.txtDuration.TabIndex = 1;
			this.txtDuration.Text = "10";
			this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(98, 126);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// btnWait
			// 
			this.btnWait.Location = new System.Drawing.Point(211, 126);
			this.btnWait.Name = "btnWait";
			this.btnWait.Size = new System.Drawing.Size(75, 23);
			this.btnWait.TabIndex = 5;
			this.btnWait.Text = "&Wait";
			this.btnWait.UseVisualStyleBackColor = true;
			this.btnWait.Click += new System.EventHandler(this.OnWait);
			// 
			// SimpleThreadingForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 211);
			this.Controls.Add(this.btnWait);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDuration);
			this.Controls.Add(this.btnStart);
			this.Name = "SimpleThreadingForm";
			this.Text = "Threading";
			this.Load += new System.EventHandler(this.OnThreadingFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDuration;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnWait;
	}
}

