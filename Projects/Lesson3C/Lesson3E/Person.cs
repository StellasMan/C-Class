using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3E
{
    public class GenericStack<T>
    {
        public GenericStack(int nSize=100)
        {
            values = new T[nSize];
        }

        public void Push(T Value)
        {
            values[nCurrent++] = Value;
        }

        public T Pop()
        {
            return values[--nCurrent];
        }

        private T[] values;
        private int nCurrent = 0;
    }

    public class GenericStackM<T> : GenericStack<T>
    {
        public void Push(T Value1, T Value2)
        {
            base.Push(Value1);
            base.Push(Value2);
        }
    }

    public class Person
    {
        public Person(string LName, string FName)
        {
            m_LName = LName;
            m_FName = FName;
        }

        public double[] Grades = { 2.5, 3.5, 4.0, 2.7, 3.0 };

        public string LName
        {
            get
            {
                return m_LName;
            }
        }

        public string MName
        {
            get;
            set;
        }

        public double this[int indx]
        {
            get
            {
                return Grades[indx];
            }

            set
            {
                if ((value < 0.0) || (value > 4.0))
                    Grades[indx] = value;
            }
        }

        private string m_LName;
        private string m_FName;
    }
}
