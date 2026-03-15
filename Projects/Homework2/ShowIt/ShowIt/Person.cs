using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowIt
{
    public class Person
    {
        public Person(string FName, string LName, DateTime dtBirth)
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
                TimeSpan tsAge = DateTime.Now - m_dtBirth;
                return (int)(tsAge.TotalDays / 365.25);
            }
        }

        private string m_LName;
        private string m_FName;
        private DateTime m_dtBirth;
    }

    public class Employee : Person
    {
        public Employee(string LName, string FName, DateTime dtBirth, DateTime dtStartDate, int nEmployeeID)
            : base(LName, FName, dtBirth)
        {
            m_dtStartDate = dtStartDate;
            m_nEmployeeID = nEmployeeID;
        }

        public DateTime StartDate
        {
            get
            {
                return m_dtStartDate;
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
                int nMonthsEmployed = 0;
                if (DateTime.Now > m_dtStartDate)
                {
                    int nYears = DateTime.Now.Year - m_dtStartDate.Year;
                    int nMonths = DateTime.Now.Month - m_dtStartDate.Month;
                    if (DateTime.Now.Day < m_dtStartDate.Day)
                        nMonths--;

                    nMonthsEmployed = (nYears * 12) + nMonths;
                }

                return nMonthsEmployed;
            }
        }

        private int m_nEmployeeID;
        private DateTime m_dtStartDate;
    }

}
