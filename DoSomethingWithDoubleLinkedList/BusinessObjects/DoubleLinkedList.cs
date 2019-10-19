using DoSomethingWithDoubleLinkedList.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoSomethingWithDoubleLinkedList.BusinessObjects
{
    public class DoublyLinkedList<T> : IDoubleLinkedList<T>
    {
        public IDoubleLinkedListNode<T> First { get; set; }
        public IDoubleLinkedListNode<T> Last { get; set; }

        public void AddFirst(T value)
        {
            IDoubleLinkedListNode<T> node = new DoubleLinkedListNode<T>
            {
                Value = value
            };

            if (First != null)
            {
                var currNode = First;
                First.Prev = node;
                node.Next = First;
                First = node;
            }
            else
            {
                First = node;
                Last = node;
            }

        }

        public void AddLast(T value)
        {
            IDoubleLinkedListNode<T> node = new DoubleLinkedListNode<T>
            {
                Value = value
            };

            if (Last != null)
            {
                var currNode = Last;
                Last.Next = node;
                node.Prev = Last;
                Last = node;
            }
            else
            {
                Last = node;
                First = node;  
            }
        }

        public void Reverse()
        {
            IDoubleLinkedListNode<T> temp = null;
            var current = First;

            while (current != null)
            {
                temp = current.Prev;
                current.Prev = current.Next;
                current.Next = temp;
                current = current.Prev;
            }

            if (temp != null)
            {
                First = temp.Prev;
            }
        }

        public void PrintNodes()
        {
            var currNode = First;
            Console.WriteLine("-------------");
            while (currNode != null)
            {
                Console.Write(currNode.Value); Console.Write(" Next "); if (currNode.Next != null) Console.Write(currNode.Next.Value); Console.Write(" Prev "); if (currNode.Prev != null)
                {
                    Console.Write(currNode.Prev.Value);
                }
                Console.WriteLine();
               currNode = currNode.Next;
            }
            Console.WriteLine("-------------");
        }
    }
}
