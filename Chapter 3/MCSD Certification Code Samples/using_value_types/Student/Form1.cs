using System;
using System.Windows.Forms;

namespace Student
{
	public partial class frmStudent : Form
	{
		public frmStudent()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			Student studentFirst = new Student("Manny", "Pacquiao", "Political Science");
			Student studentSecond = studentFirst;

			studentFirst.firstName = "Emmanuel";

			txtFName1.Text = studentFirst.firstName;
			txtLName1.Text = studentFirst.lastName;
			txtCourse1.Text = studentFirst.course;

			txtFName2.Text = studentSecond.firstName;
			txtLName2.Text = studentSecond.lastName;
			txtCourse2.Text = studentSecond.course;

			// Instance created, constructor NOT called
			Student studentThird;
			studentThird.firstName = "Edgar";
		}
	}
}
