namespace EmployeeDirectory
{
	partial class frmEmpDirectory
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
			this.lstEmployees = new System.Windows.Forms.ListBox();
			this.grpEmployeeInfo = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtMgrName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmpID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtHireDate = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTenure = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbEmpClass = new System.Windows.Forms.ComboBox();
			this.grpEmployeeInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(122, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Employees";
			// 
			// lstEmployees
			// 
			this.lstEmployees.FormattingEnabled = true;
			this.lstEmployees.Location = new System.Drawing.Point(39, 37);
			this.lstEmployees.Name = "lstEmployees";
			this.lstEmployees.Size = new System.Drawing.Size(224, 355);
			this.lstEmployees.TabIndex = 1;
			// 
			// grpEmployeeInfo
			// 
			this.grpEmployeeInfo.Controls.Add(this.cmbEmpClass);
			this.grpEmployeeInfo.Controls.Add(this.txtTenure);
			this.grpEmployeeInfo.Controls.Add(this.label7);
			this.grpEmployeeInfo.Controls.Add(this.txtHireDate);
			this.grpEmployeeInfo.Controls.Add(this.label6);
			this.grpEmployeeInfo.Controls.Add(this.label5);
			this.grpEmployeeInfo.Controls.Add(this.txtEmpID);
			this.grpEmployeeInfo.Controls.Add(this.label4);
			this.grpEmployeeInfo.Controls.Add(this.txtMgrName);
			this.grpEmployeeInfo.Controls.Add(this.label3);
			this.grpEmployeeInfo.Controls.Add(this.txtName);
			this.grpEmployeeInfo.Controls.Add(this.label2);
			this.grpEmployeeInfo.Location = new System.Drawing.Point(319, 37);
			this.grpEmployeeInfo.Name = "grpEmployeeInfo";
			this.grpEmployeeInfo.Size = new System.Drawing.Size(392, 262);
			this.grpEmployeeInfo.TabIndex = 2;
			this.grpEmployeeInfo.TabStop = false;
			this.grpEmployeeInfo.Text = "Employee Information";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(104, 41);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(225, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtMgrName
			// 
			this.txtMgrName.Location = new System.Drawing.Point(104, 107);
			this.txtMgrName.Name = "txtMgrName";
			this.txtMgrName.Size = new System.Drawing.Size(225, 20);
			this.txtMgrName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Manager Name:";
			// 
			// txtEmpID
			// 
			this.txtEmpID.Location = new System.Drawing.Point(104, 74);
			this.txtEmpID.Name = "txtEmpID";
			this.txtEmpID.Size = new System.Drawing.Size(225, 20);
			this.txtEmpID.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Employee ID:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Employee Class:";
			// 
			// txtHireDate
			// 
			this.txtHireDate.Location = new System.Drawing.Point(104, 173);
			this.txtHireDate.Name = "txtHireDate";
			this.txtHireDate.Size = new System.Drawing.Size(225, 20);
			this.txtHireDate.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(41, 177);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Hire Date:";
			// 
			// txtTenure
			// 
			this.txtTenure.Location = new System.Drawing.Point(104, 206);
			this.txtTenure.Name = "txtTenure";
			this.txtTenure.Size = new System.Drawing.Size(225, 20);
			this.txtTenure.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(52, 210);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Tenure:";
			// 
			// cmbEmpClass
			// 
			this.cmbEmpClass.FormattingEnabled = true;
			this.cmbEmpClass.Location = new System.Drawing.Point(104, 141);
			this.cmbEmpClass.Name = "cmbEmpClass";
			this.cmbEmpClass.Size = new System.Drawing.Size(173, 21);
			this.cmbEmpClass.TabIndex = 12;
			// 
			// frmEmpDirectory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 432);
			this.Controls.Add(this.grpEmployeeInfo);
			this.Controls.Add(this.lstEmployees);
			this.Controls.Add(this.label1);
			this.Name = "frmEmpDirectory";
			this.Text = "Employee Directory";
			this.Load += new System.EventHandler(this.OnEmpDirectoryFormLoad);
			this.grpEmployeeInfo.ResumeLayout(false);
			this.grpEmployeeInfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstEmployees;
		private System.Windows.Forms.GroupBox grpEmployeeInfo;
		private System.Windows.Forms.ComboBox cmbEmpClass;
		private System.Windows.Forms.TextBox txtTenure;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtHireDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEmpID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMgrName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
	}
}

