using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3E
{
    class Person
    {
        public Person(string LName, string FName)
        {
            m_LName = LName;
            m_FName = FName;
        }

        int[] scores = { 85, 76, 90, 100, 50 };

        public int this[int indx]
        {
            get
            {
                return scores[indx];
            }

            set
            {
                scores[indx] = value;
            }
        }

        public double GPA
        {
            get;
            set;
        }

        public string LName
        {
            get
            {
                return m_LName;
            }

            set
            {
                m_LName = value;
            }
        }

        public string FName
        {
            get
            {
                return m_FName;
            }
        }


        private string m_LName;
        private string m_FName;
    }
}
