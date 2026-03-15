using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject5B
{
    public enum GENDER
    {
        MALE,
        FEMALE
    }

    public class Person : IComparable<Person>
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

        // Perform a comparison, first by name, then by Age
        public int CompareTo(Person perItem)
        {
            int nCompare = this.Name.CompareTo(perItem.Name);
            if (nCompare == 0)
            {
                nCompare = (this.Age < perItem.Age) ? -1 : (this.Age > perItem.Age ? 1 : 0);
            }

            return nCompare;
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
}
