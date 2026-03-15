namespace HelloWorld
{
	partial class Form1
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
			this.lblNumber1 = new System.Windows.Forms.Label();
			this.lblNumber2 = new System.Windows.Forms.Label();
			this.txtNumber1 = new System.Windows.Forms.TextBox();
			this.txtNumber2 = new System.Windows.Forms.TextBox();
			this.btnCompute = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNumber1
			// 
			this.lblNumber1.AutoSize = true;
			this.lblNumber1.Location = new System.Drawing.Point(99, 52);
			this.lblNumber1.Name = "lblNumber1";
			this.lblNumber1.Size = new System.Drawing.Size(56, 13);
			this.lblNumber1.TabIndex = 3;
			this.lblNumber1.Text = "Number 1:";
			// 
			// lblNumber2
			// 
			this.lblNumber2.AutoSize = true;
			this.lblNumber2.Location = new System.Drawing.Point(99, 86);
			this.lblNumber2.Name = "lblNumber2";
			this.lblNumber2.Size = new System.Drawing.Size(56, 13);
			this.lblNumber2.TabIndex = 4;
			this.lblNumber2.Text = "Number 2:";
			// 
			// txtNumber1
			// 
			this.txtNumber1.Location = new System.Drawing.Point(171, 49);
			this.txtNumber1.Name = "txtNumber1";
			this.txtNumber1.Size = new System.Drawing.Size(100, 20);
			this.txtNumber1.TabIndex = 5;
			this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNumber2
			// 
			this.txtNumber2.Location = new System.Drawing.Point(171, 83);
			this.txtNumber2.Name = "txtNumber2";
			this.txtNumber2.Size = new System.Drawing.Size(100, 20);
			this.txtNumber2.TabIndex = 6;
			this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCompute
			// 
			this.btnCompute.Location = new System.Drawing.Point(148, 168);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(75, 23);
			this.btnCompute.TabIndex = 7;
			this.btnCompute.Text = "&Compute";
			this.btnCompute.UseVisualStyleBackColor = true;
			this.btnCompute.Click += new System.EventHandler(this.OnComputeClick);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnCompute;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 236);
			this.Controls.Add(this.btnCompute);
			this.Controls.Add(this.txtNumber2);
			this.Controls.Add(this.txtNumber1);
			this.Controls.Add(this.lblNumber2);
			this.Controls.Add(this.lblNumber1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Hello World Application";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblNumber1;
		private System.Windows.Forms.Label lblNumber2;
		private System.Windows.Forms.TextBox txtNumber1;
		private System.Windows.Forms.TextBox txtNumber2;
		private System.Windows.Forms.Button btnCompute;
	}
}

