using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractStudent
{
	public partial class frmAbstractStudent : Form
	{
		private HighSchoolStudent m_highStudent;
		private CollegeStudent m_collStudent;

		public frmAbstractStudent()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			HighSchoolStudent highStudent = new HighSchoolStudent("Rodrigo", "Duterte", 2.5, false);
			CollegeStudent collStudent = new CollegeStudent("Leah", "Salonga", "Medicine", 3.9);

			txtFName1.Text = highStudent.FirstName;
			txtLName1.Text = highStudent.LastName;
			txtSchool.Text = HighSchoolStudent.SchoolName;
			txtGPA1.Text = highStudent.GPA.ToString();
			chkIsOnTrackTeam.Checked = highStudent.IsOnTrackTeam;

			txtFName2.Text = collStudent.FirstName;
			txtLName2.Text = collStudent.LastName;
			txtMajor.Text = collStudent.ChoiceOfMajor;
			txtGPA2.Text = collStudent.GPA.ToString();

			m_highStudent = highStudent;
			m_collStudent = collStudent;

			Control[] ControlArray = new Control[]
				{
					grpAction,
					radioHighSchool,
					radioCollege,
					btnDetails,
					btnSayHello
				};

			foreach (Control ctrlItem in ControlArray)
				ctrlItem.Enabled = true;
		}

		private Student GetStudent()
		{
			return radioHighSchool.Checked 
				? m_highStudent as Student
				: m_collStudent as Student;
		}

		private void OnDetails(object sender, EventArgs e)
		{
			Student myStudent = GetStudent();
			myStudent.ShowDetails();
		}

		private void btnSayHello_Click(object sender, EventArgs e)
		{
			Student myStudent = GetStudent();
			myStudent.SayHello();
		}
	}
}
