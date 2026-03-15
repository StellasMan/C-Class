using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLink
{
    public class DoubleAdd<T> : LinkedList<T>
    {
        public void Add(T First, T Second)
        {
            AddFirst(First);
            AddLast(Second);
        }
    }
}
