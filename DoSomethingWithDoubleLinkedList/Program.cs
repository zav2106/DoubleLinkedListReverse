using DoSomethingWithDoubleLinkedList.BusinessObjects;
using DoSomethingWithDoubleLinkedList.Interfaces;
using System;

namespace DoSomethingWithDoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string repka= "Репка";
            var fable = new DoublyLinkedList<string>();
            fable.AddFirst(repka);
            fable.AddLast("Бабка");
            fable.AddLast("Дедка");
            fable.AddLast("Внучка");
            fable.AddLast("Жучка");
            fable.AddLast("Кошка");
            fable.AddLast("Мышка");
            fable.PrintNodes();
            fable.Reverse();
            fable.PrintNodes();
            //Console.WriteLine("Hello World!");
        }
    }
}
