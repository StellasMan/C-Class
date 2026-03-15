using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLink
{
    public class UniqueHash<T> : HashSet<T>
    {
        public new bool Add(T item)
        {
            bool bAdded = false;
            if (!Contains(item))
            {
                base.Add(item);
                Console.WriteLine("Added item");
                bAdded = true;
            }
            else
            {
                Console.WriteLine("Attempt to add duplicate");
            }

            return bAdded;
        }
    }

    public class MyDerivedClass : IComparable
    {
        public int CompareTo(Object obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }
    }
}
