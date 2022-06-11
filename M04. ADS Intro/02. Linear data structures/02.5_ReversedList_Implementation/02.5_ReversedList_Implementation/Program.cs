using System;

namespace _02._5_ReversedList_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversedList<int> list = new ReversedList<int>();

            list.Add(1);
            list.Add(2);

            Console.WriteLine(list.Capacity);
            list.Add(3);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);

            int removed = list.RemoveAt(1);
            Console.WriteLine(removed);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
