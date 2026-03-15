using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractStudent
{
	public abstract class Student
	{
		public Student(string firstName, string lastName, double gpa=4.0)
		{
			FirstName = firstName;
			LastName = lastName;
			GPA = gpa;
		}

		public string FirstName;
		public string LastName;
		public double GPA;

		public virtual void SayHello()
		{
			MessageBox.Show("Whatsssup?");
		}

		public abstract void ShowDetails();
	}

	public class HighSchoolStudent : Student
	{
		public HighSchoolStudent(string firstName, string lastName, double GPA, bool isOnTrackTeam)
		: base(firstName, lastName, GPA)
		{
			IsOnTrackTeam = isOnTrackTeam;
		}

		public readonly bool IsOnTrackTeam;
		public const string SchoolName = "Philippine High School for the Arts";

		public override void ShowDetails()
		{
			MessageBox.Show
			(
				String.Format("Name: {0}, {1}\nGPA: {2}\nSchool: {3}\nTrack Team: {4}",
						LastName,
						FirstName,
						GPA,
						SchoolName,
						IsOnTrackTeam ? "Yes" : "No")
			);
		}
	}

	public class CollegeStudent : Student
	{
		public CollegeStudent(string firstName, string lastName, string choiceOfMajor, double GPA)
		: base(firstName, lastName, GPA)
		{
			ChoiceOfMajor = choiceOfMajor;
		}

		public readonly string ChoiceOfMajor;
		public override void ShowDetails()
		{
			MessageBox.Show
			(
				String.Format("Name: {0}, {1}\nGPA: {2}\nMajor: {3}",
						LastName,
						FirstName,
						GPA,
						ChoiceOfMajor)
			);
		}

		public override void SayHello()
		{
			MessageBox.Show("Good evening sir");
		}
	}
}
