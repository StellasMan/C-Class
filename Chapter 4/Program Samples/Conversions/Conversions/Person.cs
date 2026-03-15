using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    public class Person
    {
        public Person(string FName, string LName, DateTime dtBirthDate)
        {
            m_FName = FName;
            m_LName = LName;
            m_dtBirthDate = dtBirthDate;
        }

        DateTime BirthDate
        {
            get
            {
                return m_dtBirthDate;
            }
        }

        int Age
        {
            get
            {
                TimeSpan tsAge = DateTime.Now - m_dtBirthDate;
                return (int)(tsAge.TotalDays / 365.25);
            }
        }

        public string Name
        {
            get
            {
                return $"{m_LName}, {m_FName}";
            }
        }

        private DateTime m_dtBirthDate;
        private string m_FName;
        private string m_LName;
    }

    public class Employee : Person
    {
        public Employee(string FName, string LName, DateTime dtBirthDate, DateTime dtStartDate)
            : base(FName, LName, dtBirthDate)
        {
            m_dtStartDate = dtStartDate;
        }

        public string Info
        {
            get
            {
                return $"{Name}; Start Date: {m_dtStartDate}";
            }
        }

        private DateTime m_dtStartDate;
    }
}
