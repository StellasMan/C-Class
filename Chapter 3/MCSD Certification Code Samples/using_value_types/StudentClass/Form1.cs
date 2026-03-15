using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentClass
{
	public partial class frmStudent : Form
	{
		public frmStudent()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			Student studentFirst = new Student("Manny", "Pacquiao");
			Student studentSecond = studentFirst;

			studentFirst.firstName = "Emmanuel";

			txtFName1.Text = studentFirst.firstName;
			txtLName1.Text = studentFirst.lastName;
			txtCourse1.Text = studentFirst.course;

			txtFName2.Text = studentSecond.firstName;
			txtLName2.Text = studentSecond.lastName;
			txtCourse2.Text = studentSecond.course;

			System.Random rand = new Random();
			for (int count = 0; count < 10; count++)
			{
				double itemScore = rand.Next(800, 1000) / 10.0;
				Debug.WriteLine(String.Format("Test score {0} is {1}", count + 1, itemScore));
				studentFirst.SetTestScore(count, itemScore);
			}

			double avgScore = studentFirst.GetTestAverage();
			MessageBox.Show(
				String.Format("Student #{3} {0} {1} had an average score of {2}",
					studentFirst.firstName,
					studentFirst.lastName,
					avgScore,
					Student.studentCount)
				);
		}
	}
}
