using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public sealed class SortedLinkedList<T> : LinkedList<T> where T : IComparable<T>
    {
        public void Add(T tItem)
        {
            bool bInserted = false;
            LinkedListNode<T> llListNode = this.First;
            while (llListNode != null)
            {
                T tLLItem = llListNode.Value;
                if (tItem.CompareTo(tLLItem) < 0)
                {
                    base.AddBefore(llListNode, new LinkedListNode<T>(tItem));
                    bInserted = true;
                    break;
                }

                llListNode = llListNode.Next;
            }

            if (!bInserted)
                base.AddLast(tItem);
        }
    }

    public class UniqueHashSet<T> : HashSet<T> where T : IComparable
    {
        public new bool Add(T item)
        {
            bool bRetVal = false;
            if (!Contains(item))
            {
                base.Add(item);
                Console.WriteLine("Added item");
                bRetVal = true;
            }
            else
            {
                Console.WriteLine("Attempt to add duplicate!");
            }

            return bRetVal;
        }
    }
}
