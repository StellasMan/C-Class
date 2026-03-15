using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    public class Employee : Person
    {
        public Employee(string LName, string FName, GENDER gender, DateTime dtBirth, DateTime? dtStartDate, int nEmployeeID)
            : base(LName, FName, gender, dtBirth)
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
}
