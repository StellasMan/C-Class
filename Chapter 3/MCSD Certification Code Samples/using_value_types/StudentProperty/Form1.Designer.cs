namespace StudentProperty
{
	partial class frmStudentProperties
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
			this.grpName = new System.Windows.Forms.GroupBox();
			this.txtLName = new System.Windows.Forms.TextBox();
			this.txtMI = new System.Windows.Forms.TextBox();
			this.txtFName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.grpPersonal = new System.Windows.Forms.GroupBox();
			this.txtGPA = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtProgram = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.numAge = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.grpName.SuspendLayout();
			this.grpPersonal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
			this.SuspendLayout();
			// 
			// grpName
			// 
			this.grpName.Controls.Add(this.txtLName);
			this.grpName.Controls.Add(this.txtMI);
			this.grpName.Controls.Add(this.txtFName);
			this.grpName.Controls.Add(this.label3);
			this.grpName.Controls.Add(this.label2);
			this.grpName.Controls.Add(this.label1);
			this.grpName.Location = new System.Drawing.Point(13, 26);
			this.grpName.Name = "grpName";
			this.grpName.Size = new System.Drawing.Size(447, 96);
			this.grpName.TabIndex = 0;
			this.grpName.TabStop = false;
			this.grpName.Text = "Name";
			// 
			// txtLName
			// 
			this.txtLName.Location = new System.Drawing.Point(264, 42);
			this.txtLName.Name = "txtLName";
			this.txtLName.Size = new System.Drawing.Size(170, 20);
			this.txtLName.TabIndex = 5;
			this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtMI
			// 
			this.txtMI.Location = new System.Drawing.Point(179, 42);
			this.txtMI.Name = "txtMI";
			this.txtMI.Size = new System.Drawing.Size(54, 20);
			this.txtMI.TabIndex = 4;
			this.txtMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtFName
			// 
			this.txtFName.BackColor = System.Drawing.SystemColors.Window;
			this.txtFName.Location = new System.Drawing.Point(12, 42);
			this.txtFName.Name = "txtFName";
			this.txtFName.Size = new System.Drawing.Size(131, 20);
			this.txtFName.TabIndex = 3;
			this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(336, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Last";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(174, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Middle Initial";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First";
			// 
			// grpPersonal
			// 
			this.grpPersonal.Controls.Add(this.txtGPA);
			this.grpPersonal.Controls.Add(this.label6);
			this.grpPersonal.Controls.Add(this.txtProgram);
			this.grpPersonal.Controls.Add(this.label5);
			this.grpPersonal.Controls.Add(this.numAge);
			this.grpPersonal.Controls.Add(this.label4);
			this.grpPersonal.Location = new System.Drawing.Point(13, 147);
			this.grpPersonal.Name = "grpPersonal";
			this.grpPersonal.Size = new System.Drawing.Size(447, 115);
			this.grpPersonal.TabIndex = 1;
			this.grpPersonal.TabStop = false;
			this.grpPersonal.Text = "Personal";
			// 
			// txtGPA
			// 
			this.txtGPA.Location = new System.Drawing.Point(310, 31);
			this.txtGPA.Name = "txtGPA";
			this.txtGPA.Size = new System.Drawing.Size(61, 20);
			this.txtGPA.TabIndex = 15;
			this.txtGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(273, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "GPA:";
			// 
			// txtProgram
			// 
			this.txtProgram.Location = new System.Drawing.Point(113, 31);
			this.txtProgram.Name = "txtProgram";
			this.txtProgram.Size = new System.Drawing.Size(131, 20);
			this.txtProgram.TabIndex = 12;
			this.txtProgram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(58, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Program:";
			// 
			// numAge
			// 
			this.numAge.Location = new System.Drawing.Point(113, 69);
			this.numAge.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.numAge.Name = "numAge";
			this.numAge.Size = new System.Drawing.Size(61, 20);
			this.numAge.TabIndex = 13;
			this.numAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(78, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Age:";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(205, 291);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// frmStudentProperties
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 341);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.grpPersonal);
			this.Controls.Add(this.grpName);
			this.MinimumSize = new System.Drawing.Size(500, 380);
			this.Name = "frmStudentProperties";
			this.Text = "Student Properties";
			this.grpName.ResumeLayout(false);
			this.grpName.PerformLayout();
			this.grpPersonal.ResumeLayout(false);
			this.grpPersonal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpName;
		private System.Windows.Forms.TextBox txtLName;
		private System.Windows.Forms.TextBox txtMI;
		private System.Windows.Forms.TextBox txtFName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grpPersonal;
		private System.Windows.Forms.TextBox txtGPA;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtProgram;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numAge;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnStart;
	}
}

