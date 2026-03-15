using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProperty
{
	public partial class frmStudentProperties : Form
	{
		Student student;

		public frmStudentProperties()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			// Constructor uses position arguments, named arguments and default argument (p_gpa)
			student = new Student("Bella", "Flores", p_age: 92, p_program: "Performing Arts");

			txtFName.Text = student.FirstName;
			txtMI.Text = student.MiddleInitial.ToString();
			txtLName.Text = student.LastName;
			txtProgram.Text = student.Program;
			numAge.Value = student.Age;
			txtGPA.Text = student.GPA.ToString("0.00");

			student.displayDetails();

			student[0] = "Math 101";
			student[1] = "Social Studies";
			student[12] = "Computer Science 220";
		}
	}
}
