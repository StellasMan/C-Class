using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace StudentProperty
{
	public class Student
	{
		// ********** Note that all data is private **********
		private string[] studentClasses = new string[10];

		private string firstName;
		private char middleInitial;
		private string lastName;
		private int age;
		private string program;
		private double gpa;

		public Student(string p_first, string p_last, char p_middle = 'X', int p_age=18, string p_program = "Computer Science", double p_gpa=3.0)
		{
			firstName = p_first;
			lastName = p_last;
			middleInitial = p_middle;
			age = p_age;
			program = p_program;
			gpa = p_gpa;
		}

		public string this[int index]
		{
			get
			{
				String aClass = String.Empty;

				if ((index >= 0) && (index < studentClasses.GetLength(0)))
				{
					aClass = studentClasses[index];
				}
				else
				{
					MessageBox.Show("Invalid index");
				}

				return aClass;
			}

			set
			{
				if ((index >= 0) && (index < studentClasses.GetLength(0)))
				{
					studentClasses[index] = value;
				}
				else
				{
					MessageBox.Show("Invalid index");
				}
			}
		}

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public char MiddleInitial
		{
			get { return middleInitial; }
			set { middleInitial = value; }
		}

		public int Age
		{
			get { return age; }
			set
			{
				if ((value > 6) && (value < 100))
				{
					age = value;
				}
				else
				{
					MessageBox.Show("Student age must be greater than 6 and less than 100");
				}
			}
		}

		public string Program
		{
			get { return program; }
			set { program = value; }
		}

		public double GPA
		{
			get { return gpa; }
			set
			{
				if ((value >= 0) && (value <= 4.0))
				{
					gpa = value;
				}
				else
				{
					MessageBox.Show("GPA must be positive and cannot be greater than 4.0");
				}
			}
		}

		public void displayDetails()
		{
			MessageBox.Show(
				FirstName + " " + MiddleInitial + " " + LastName + 
				"\nProgram: " + Program + 
				"\nGPA: " + String.Format("{0:0.00}", GPA) + 
				"\nAge: " + Age);
		}
	}
}
