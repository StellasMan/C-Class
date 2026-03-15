using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public interface IMyInterface1
    {
        void MyFunc();
        void MyFunc2();
    }

    public interface IMyInterface2
    {
        void Func1();
        void Func2();
    }


    public class Person : IComparable<Person>, IMyInterface1, IMyInterface2
    {
        public Person(string FName, string LName, DateTime? dtBirth)
        {
            m_FName = FName;
            m_LName = LName;
            m_dtBirth = dtBirth;
        }

        public string Name
        {
            get
            {
                return $"{m_LName}, {m_FName}";
            }
        }

        public int Age
        {
            get
            {
                TimeSpan tsAge = DateTime.Now - m_dtBirth.Value;
                return (int)(tsAge.TotalDays / 365.25);
            }
        }

        public int CompareTo(Person A)
        {
            return this.Name.CompareTo(A.Name);
        }

        public void MyFunc()
        {
            Console.WriteLine("MyFunc");
        }

        public void MyFunc2()
        {
            Console.WriteLine("MyFunc2");
        }

        public void Func1()
        {
            Console.WriteLine("Func1");
        }

        public void Func2()
        {
            Console.WriteLine("Func2");
        }

        private string m_LName;
        private string m_FName;
        private DateTime? m_dtBirth;
    }

    public class Employee : Person
    {
        public Employee(string LName, string FName, DateTime dtBirth, DateTime? dtStartDate, int nEmployeeID)
            : base(LName, FName, dtBirth)
        {
            m_dtStartDate = dtStartDate;
            m_nEmployeeID = nEmployeeID;
        }

        public DateTime StartDate
        {
            get
            {
                return (m_dtStartDate.GetValueOrDefault(DateTime.Now));
            }
        }

        public int EmployeeID
        {
            get
            {
                return m_nEmployeeID;
            }
        }

        public int MonthsEmployed
        {
            get
            {
                int nTotalMonths = 0;
                if (m_dtStartDate.HasValue)
                {
                    int nYears = DateTime.Now.Year - m_dtStartDate.Value.Year;
                    int nMonths = DateTime.Now.Month - m_dtStartDate.Value.Month;
                    if (DateTime.Now.Day < m_dtStartDate.Value.Day)
                        nMonths--;

                    nTotalMonths = (nYears * 12) + nMonths;
                }

                return nTotalMonths;
            }
        }

        private int m_nEmployeeID;
        private DateTime? m_dtStartDate;
    }

    public class MyLinkedList<T> : LinkedList<T>
    {
        public void Add(T first, T last)
        {
            AddFirst(first);
            AddLast(last);
        }
    }

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person A, Person B)
        {
            return A.Name.CompareTo(B.Name);
        }
    }
}
                                                                                                                                                                                                  