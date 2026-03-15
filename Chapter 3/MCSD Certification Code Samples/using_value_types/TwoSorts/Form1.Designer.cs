namespace TwoSorts
{
	partial class frmTwoSorts
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
			this.lblIntegers = new System.Windows.Forms.Label();
			this.lstIntegers = new System.Windows.Forms.ListBox();
			this.lstStrings = new System.Windows.Forms.ListBox();
			this.lblStrings = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnSort = new System.Windows.Forms.Button();
			this.btnGeneric = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblIntegers
			// 
			this.lblIntegers.AutoSize = true;
			this.lblIntegers.Location = new System.Drawing.Point(108, 28);
			this.lblIntegers.Name = "lblIntegers";
			this.lblIntegers.Size = new System.Drawing.Size(62, 13);
			this.lblIntegers.TabIndex = 0;
			this.lblIntegers.Text = "Integer Sort";
			// 
			// lstIntegers
			// 
			this.lstIntegers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lstIntegers.FormattingEnabled = true;
			this.lstIntegers.Location = new System.Drawing.Point(77, 52);
			this.lstIntegers.Name = "lstIntegers";
			this.lstIntegers.Size = new System.Drawing.Size(124, 199);
			this.lstIntegers.TabIndex = 1;
			// 
			// lstStrings
			// 
			this.lstStrings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lstStrings.FormattingEnabled = true;
			this.lstStrings.Location = new System.Drawing.Point(284, 52);
			this.lstStrings.Name = "lstStrings";
			this.lstStrings.Size = new System.Drawing.Size(124, 199);
			this.lstStrings.TabIndex = 3;
			// 
			// lblStrings
			// 
			this.lblStrings.AutoSize = true;
			this.lblStrings.Location = new System.Drawing.Point(318, 28);
			this.lblStrings.Name = "lblStrings";
			this.lblStrings.Size = new System.Drawing.Size(56, 13);
			this.lblStrings.TabIndex = 2;
			this.lblStrings.Text = "String Sort";
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStart.Location = new System.Drawing.Point(124, 289);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// btnSort
			// 
			this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSort.Enabled = false;
			this.btnSort.Location = new System.Drawing.Point(205, 289);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(75, 23);
			this.btnSort.TabIndex = 5;
			this.btnSort.Text = "Sor&t";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.OnSort);
			// 
			// btnGeneric
			// 
			this.btnGeneric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnGeneric.Enabled = false;
			this.btnGeneric.Location = new System.Drawing.Point(286, 289);
			this.btnGeneric.Name = "btnGeneric";
			this.btnGeneric.Size = new System.Drawing.Size(75, 23);
			this.btnGeneric.TabIndex = 6;
			this.btnGeneric.Text = "&Generic";
			this.btnGeneric.UseVisualStyleBackColor = true;
			this.btnGeneric.Click += new System.EventHandler(this.OnGeneric);
			// 
			// frmTwoSorts
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 341);
			this.Controls.Add(this.btnGeneric);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lstStrings);
			this.Controls.Add(this.lblStrings);
			this.Controls.Add(this.lstIntegers);
			this.Controls.Add(this.lblIntegers);
			this.MinimumSize = new System.Drawing.Size(500, 380);
			this.Name = "frmTwoSorts";
			this.Text = "Two Sorts";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblIntegers;
		private System.Windows.Forms.ListBox lstIntegers;
		private System.Windows.Forms.ListBox lstStrings;
		private System.Windows.Forms.Label lblStrings;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.Button btnGeneric;
	}
}

