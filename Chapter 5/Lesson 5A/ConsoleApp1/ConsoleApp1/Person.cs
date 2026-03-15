using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Parent class, Base class, or Superclass
    public class Person : IComparable<Person>, IEquatable<Person>
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

        public int CompareTo(Person perInput)
        {
            return perInput.Name.CompareTo(this.Name);
        }

        public bool Equals(Person perInput)
        {
            return (perInput.Name.CompareTo(this.Name) == 0);
        }

        private string m_LName;
        private string m_FName;
        private DateTime? m_dtBirth;
    }

    // Derived class, child class, or Subclass
    public class Employee : Person
    {
        public Employee(string FName, string LName, DateTime? dtBirth, DateTime startDate)
            : base(FName, LName, dtBirth)
        {
            m_dtStartDate = startDate;
        }

        public Employee(string FName, string LName, DateTime? dtBirth, DateTime startDate, bool bMarried)
            : this(FName, LName, dtBirth, startDate)
        {
            m_bMarried = bMarried;
        }

        DateTime m_dtStartDate;
        bool m_bMarried;
    }
}


