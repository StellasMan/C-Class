namespace Types
{
	partial class TypesForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.txtSeason = new System.Windows.Forms.TextBox();
			this.lblSeason = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(100, 151);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 28);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnStartClick);
			// 
			// txtSeason
			// 
			this.txtSeason.Location = new System.Drawing.Point(65, 46);
			this.txtSeason.Multiline = true;
			this.txtSeason.Name = "txtSeason";
			this.txtSeason.Size = new System.Drawing.Size(177, 68);
			this.txtSeason.TabIndex = 3;
			// 
			// lblSeason
			// 
			this.lblSeason.AutoSize = true;
			this.lblSeason.Location = new System.Drawing.Point(130, 27);
			this.lblSeason.Name = "lblSeason";
			this.lblSeason.Size = new System.Drawing.Size(43, 13);
			this.lblSeason.TabIndex = 4;
			this.lblSeason.Text = "Season";
			// 
			// TypesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 228);
			this.Controls.Add(this.lblSeason);
			this.Controls.Add(this.txtSeason);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "TypesForm";
			this.Text = "Types";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtSeason;
		private System.Windows.Forms.Label lblSeason;
	}
}

