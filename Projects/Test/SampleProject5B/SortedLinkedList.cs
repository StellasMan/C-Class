using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject5B
{
    class SortedLinkedList<T> : LinkedList<T> where T : IComparable<T>
    {
        public void Add(T item)
        {
            bool bAdded = false;
            LinkedListNode<T> llListNode = this.First;
            while(llListNode != null)
            {
                T tLLItem = llListNode.Value;
                if (item.CompareTo(tLLItem) < 0)
                {
                    base.AddBefore(llListNode, new LinkedListNode<T>(item));
                    bAdded = true;
                    break;
                }

                llListNode = llListNode.Next;
            }

            if (!bAdded)
            {
                base.AddLast(new LinkedListNode<T>(item));
            }
        }
    }
}
