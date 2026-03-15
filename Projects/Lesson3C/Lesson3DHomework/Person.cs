using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3DHomework
{
    public enum GENDER
    {
        MALE,
        FEMALE
    }

    public abstract class Person
    {
        public Person(string lName, string fName, char chMI, GENDER gMF, double dWeight)
        {
            m_lName = lName;
            m_fName = fName;
            m_chMI = chMI;
            m_Gender = gMF;
            m_dWeight = dWeight;
        }

        public abstract void Talk();

        public string m_lName;
        public string m_fName;
        public char m_chMI;

        public string Name
        {
            get => $"{m_fName} {m_lName}";
            set => m_fName = value;
        }

        public string NickName
        {
            get;
        }

        public string Gender => (m_Gender == GENDER.FEMALE) ? "Girl" : "Guy";

        public readonly GENDER m_Gender;

        private double m_dWeight;
    }

    public class Student : Person
    {
        public Student(string lName, string fName, char chMI, GENDER gMF, double dWeight, double dGPA)
            : base(lName, fName, chMI, gMF, dWeight)
        {
            m_dGPA = dGPA;
        }

        public override void Talk()
        {
            Console.WriteLine(String.Format("Hello my name is {0} and I am a {1} student.", m_fName, m_Gender));
        }

        protected double m_dGPA;
    }

    public class Professor : Person
    {
        public Professor(string lName, string fName, char chMI, GENDER gMF, double dWeight, bool bTenured)
            : base(lName, fName, chMI, gMF, dWeight)
        {
            m_bTenured = bTenured;
        }

        public override void Talk()
        {
            Console.WriteLine(String.Format("Hello my name is Professor {0} and I am {1} professor.", m_lName, m_bTenured ? "a Tenured" : "an Untenured"));
        }

        public readonly bool m_bTenured;
    }

    public class Administrator : Professor
    {
        public Administrator(string lName, string fName, char chMI, GENDER gMF, double dWeight, string sCollege)
            : base(lName, fName, chMI, gMF, dWeight, true)
        {
            m_sCollege = sCollege;
        }

        public override void Talk()
        {
            String sTitle = (m_Gender == GENDER.FEMALE) ? "Ms." : "Mr.";
            Console.WriteLine($"Hello my name is {sTitle} {m_lName}.");
        }

        public string m_sCollege;
    }
}
