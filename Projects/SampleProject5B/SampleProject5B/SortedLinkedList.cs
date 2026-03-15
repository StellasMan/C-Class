using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject5B
{
    class SortedLinkedList<T> : LinkedList<T> where T : IComparable<T>
    {
        public enum SLL_DIRECTION
        {
            SLL_UP,
            SLL_DOWN
        };

        public SortedLinkedList(SLL_DIRECTION sllDirection = SLL_DIRECTION.SLL_UP)
        {
            m_sllDirection = sllDirection;
        }

        public void Add(T item)
        {
            bool bAdded = false;
            bool bInsert = false;
            LinkedListNode<T> llListNode = this.First;
            while(llListNode != null)
            {
                T tLLItem = llListNode.Value;
                bInsert = (m_sllDirection == SLL_DIRECTION.SLL_UP) ? (item.CompareTo(tLLItem) < 0) : (item.CompareTo(tLLItem) >= 0);
                if (bInsert)
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

        private readonly SLL_DIRECTION m_sllDirection;
    }
}
