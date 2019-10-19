using DoSomethingWithDoubleLinkedList.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoSomethingWithDoubleLinkedList.BusinessObjects
{
    public class DoubleLinkedListNode<T>: IDoubleLinkedListNode<T>
    {
        public T Value { get; set; }
        public IDoubleLinkedListNode<T> Next { get; set; }
        public IDoubleLinkedListNode<T> Prev { get; set; }

        //public DoubleLinkedListNode(object data, DoubleLinkedListNode<T> next, DoubleLinkedListNode<T> previous)
        //{
        //    Value = (T)Value;
        //    PreviousNode = previous;
        //    NextNode = next;
        //}
    }
}
