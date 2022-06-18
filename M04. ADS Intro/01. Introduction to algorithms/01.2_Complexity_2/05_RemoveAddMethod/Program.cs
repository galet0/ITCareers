using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_RemoveAddMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            list.Sort();

            Console.WriteLine(string.Join(" ", list));

            int number = int.Parse(Console.ReadLine());
            if (!list.Contains(number))
            {
                InsertIntoSortedList(list, number);
            }
            else
            {
                list.Remove(number);
            }

            Console.WriteLine(string.Join(" ", list));
        }
        
        private static void InsertIntoSortedList(List<int> numbers, int number)
        {
            int index = numbers.BinarySearch(number);

            if(index < 0)
            {
                index = ~index;
            }

            numbers.Insert(index, number);
        }

    }
}
