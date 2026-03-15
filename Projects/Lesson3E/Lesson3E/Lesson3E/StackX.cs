using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3E
{
    public class StackX<T>
    {
        public StackX(int nSize=100)
        {
            values = new T[nSize];
        }

        public void Push(T value)
        {
            values[nCurrent++] = value;
        }

        public T Pop()
        {
            return values[--nCurrent];
        }

        private int nCurrent = 0;
        private T[] values;
    }
}
