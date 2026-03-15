using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public enum GENDER
    {
        MALE,
        FEMALE
    }

    public class Person
    {
        public Person(string FName, string LName, GENDER gender)
        {
            m_FName = FName;
            m_LName = LName;
            m_Gender = gender;
        }

        public virtual void SayHI()
        {
            Console.WriteLine("Hi! My name is " + m_FName + " " + m_LName + ". I am a " + m_Gender + " person.");
        }

        public string m_FName;
        public string m_LName;
        public GENDER m_Gender;

        // private bool m_bOnProbation = false;
    }


    public class Student : Person
    {
        public Student(string FName, string LName, string Major, GENDER gender)
            : base(FName, LName, gender)
        {
            m_Major = Major;
        }

        public override void SayHI()
        {
            Console.WriteLine("Hi! My name is " + m_FName + " " + m_LName + ". I am a " + m_Gender + " student and I major in " + m_Major + ".");
        }

        string m_Major;
    }

    public class Teacher : Person
    {
        public Teacher(string FName, string LName, string Subject, GENDER gender)
            : base(FName, LName, gender)
        {
            m_Subject = Subject;
        }

        public override void SayHI()
        {
            Console.WriteLine("Hi! My name is " + m_FName + " " + m_LName + ". I am a " + m_Gender + " teacher and I teach " + m_Subject + ".");
        }

        string m_Subject;
    }


    public class Administrator : Person
    {
        public Administrator(string FName, string LName, string College, GENDER gender)
            : base(FName, LName, gender)
        {
            m_College = College;
        }

        public override void SayHI()
        {
            Console.WriteLine("Hi! My name is " + m_FName + " " + m_LName + ". I am a " + m_Gender + " and I am an administrator over the " + m_College + " college.");
        }

        string m_College;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person LeaS = new Person("Lea", "Salonga", GENDER.FEMALE);
            LeaS.SayHI();

            Teacher JoseR = new Teacher("Jose", "Rizal", "Medicine", GENDER.MALE);
            JoseR.SayHI();

            Person someGuy = (Person)JoseR;
            someGuy.SayHI();

            Console.ReadKey();
        }
    }
}
