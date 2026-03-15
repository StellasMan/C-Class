using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
	public struct Student
	{
		// Constructor must initialize ALL member variables
		public Student(string p_firstName, string p_lastName, string p_course)
		{
			firstName = p_firstName;
			lastName = p_lastName;
			course = p_course;
			score1 =
			score2 =
			score3 =
			score4 =
			score5 =
			average = 0;
		}

		public string firstName;
		public string lastName;
		public string course;
		public double score1;
		public double score2;
		public double score3;
		public double score4;
		public double score5;

		// Not allowed to initialize variable in declaration
		// public double score6 = 10;

		// 'protected' not allowed in structures
		// protected string homeAddress;

		private double average;
	}
}
