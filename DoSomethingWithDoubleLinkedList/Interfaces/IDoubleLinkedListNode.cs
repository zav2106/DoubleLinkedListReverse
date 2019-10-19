using System;
using System.Collections.Generic;
using System.Text;

namespace DoSomethingWithDoubleLinkedList.Interfaces
{
    public interface IDoubleLinkedListNode<T>
    {
        T Value { get; set; }
        IDoubleLinkedListNode<T> Next { get; set; }
        IDoubleLinkedListNode<T> Prev { get; set; }
    }
}
