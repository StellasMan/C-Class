using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
	public class Student
	{
		public Student()
		{
			studentCount++;
		}

		public Student(string p_firstName, string p_lastName, string p_course="Political Science")
		{
			firstName = p_firstName;
			lastName = p_lastName;
			course = p_course;

			studentCount++;
		}

		public void SetTestScore(int testNumber, double testScore)
		{
			if ((testNumber >= 0) && (testNumber <= 9))
			{
				testScores[testNumber] = testScore;
			}
		}

		public double GetTestAverage()
		{
			double averageScore = 0.0;
			double totalPoints = 0;
			foreach (double testScore in testScores)
				totalPoints += testScore;

			averageScore = (totalPoints / testScores.GetLength(0));

			System.Diagnostics.Debug.WriteLine("Average score: " + averageScore);

			// Alternatively, use built-in function
			averageScore = testScores.Average();
			System.Diagnostics.Debug.WriteLine("Average score: " + averageScore);

			return averageScore;
		}

		public static void ResetStudentCount()
		{
			studentCount = 0;
		}

		public string firstName;
		public string lastName;
		public string course;

		private double[] testScores = new double[10];

		public static int studentCount = 0;
	}
}
