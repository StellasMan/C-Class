using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowIt
{
    public enum GENDER
    {
        MALE,
        FEMALE
    }

    public class Person
    {
        public Person(string FName, string LName, GENDER gender, DateTime? dtBirth)
        {
            m_FName = FName;
            m_LName = LName;
            m_Gender = gender;
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
                int nAge = 0;

                if ((m_dtBirth.HasValue) && (DateTime.Now > m_dtBirth.Value))
                {
                    nAge = DateTime.Now.Year - m_dtBirth.Value.Year;

                    // If we haven't come up to the anniversary of the date of birth, then decrement the age count by 1
                    if ((DateTime.Now.Month < m_dtBirth.Value.Month) || ((DateTime.Now.Month == m_dtBirth.Value.Month) && (DateTime.Now.Day < m_dtBirth.Value.Day)))
                    {
                        nAge--;
                    }
                }

                return nAge;
            }
        }

        public GENDER Gender
        {
            get
            {
                return m_Gender;
            }
        }

        private string m_LName;
        private string m_FName;
        private GENDER m_Gender;
        private DateTime? m_dtBirth;
    }

    public class Employee : Person
    {
        public Employee(string LName, string FName, GENDER gender, DateTime dtBirth, DateTime dtStartDate, int nEmployeeID)
            : base(LName, FName, gender, dtBirth)
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

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person A, Person B)
        {
            int nRetVal = A.Name.CompareTo(B.Name);

            if (nRetVal == 0)
            {
                nRetVal = (A.Age < B.Age) ? -1 : ((A.Age > B.Age) ? 1 : 0);
            }

            return nRetVal;
        }
    }

    public class PersonComparerDesc : IComparer<Person>
    {
        public int Compare(Person A, Person B)
        {
            int nRetVal = B.Name.CompareTo(A.Name);

            if (nRetVal == 0)
            {
                nRetVal = (B.Age < A.Age) ? -1 : ((B.Age > A.Age) ? 1 : 0);
            }

            return nRetVal;
        }
    }
}
