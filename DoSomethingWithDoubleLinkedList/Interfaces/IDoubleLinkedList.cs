﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoSomethingWithDoubleLinkedList.Interfaces
{
    public interface IDoubleLinkedList<T>
    {
        IDoubleLinkedListNode<T> First { get; set; }
        IDoubleLinkedListNode<T> Last { get; set; }
        void Reverse();
        //insert new DoubleLinkedListNode with given value at the start of the list
        void AddFirst(T value);
        //insert new DoubleLinkedListNode with given value at the end of the list
        void AddLast(T value);
    }
}
