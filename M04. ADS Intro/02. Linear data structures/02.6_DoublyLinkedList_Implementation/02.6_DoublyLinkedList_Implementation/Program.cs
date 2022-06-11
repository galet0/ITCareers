using System;

namespace _02._6_DoublyLinkedList_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddFirst(1);
            list.AddFirst(2);

            list.AddLast(3);


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            Action<int> print = x => Console.WriteLine(x);
            //print(5);

            list.ForEach(print);
        }
    }
}
