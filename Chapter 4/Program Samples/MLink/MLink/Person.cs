using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLink
{
    public class Person : IComparable<Person>
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

        public int CompareTo(Person perCheck)
        {
            return this.Name.CompareTo(perCheck.Name);
        }

        private string m_LName;
        private string m_FName;
        private DateTime m_dtBirth;
    }

}
