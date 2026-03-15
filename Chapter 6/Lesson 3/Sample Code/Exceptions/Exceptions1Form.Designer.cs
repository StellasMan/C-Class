namespace Exceptions
{
	partial class Exceptions1Form
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
			this.btnGo = new System.Windows.Forms.Button();
			this.txtDividend = new System.Windows.Forms.TextBox();
			this.txtDivisor = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(122, 154);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 6;
			this.btnGo.Text = "&Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.OnGo);
			// 
			// txtDividend
			// 
			this.txtDividend.Location = new System.Drawing.Point(30, 89);
			this.txtDividend.Name = "txtDividend";
			this.txtDividend.Size = new System.Drawing.Size(75, 20);
			this.txtDividend.TabIndex = 1;
			this.txtDividend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDivisor
			// 
			this.txtDivisor.Location = new System.Drawing.Point(122, 89);
			this.txtDivisor.Name = "txtDivisor";
			this.txtDivisor.Size = new System.Drawing.Size(75, 20);
			this.txtDivisor.TabIndex = 3;
			this.txtDivisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(214, 89);
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(75, 20);
			this.txtResult.TabIndex = 5;
			this.txtResult.TabStop = false;
			this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Dividend";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(140, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Di&visor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(233, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "&Result";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnGo;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 239);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtDivisor);
			this.Controls.Add(this.txtDividend);
			this.Controls.Add(this.btnGo);
			this.Name = "Form1";
			this.Text = "Exception Demo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.TextBox txtDividend;
		private System.Windows.Forms.TextBox txtDivisor;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

