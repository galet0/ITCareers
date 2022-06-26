using System;
using System.Collections.Generic;

namespace _01_LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 9, 1, 4, 2, 0, 4, 7, 6 };//8
            Console.WriteLine(Contains(numbers, 8));
            Console.WriteLine(LinearSearch(numbers, 8));
            Console.WriteLine(LinearSearch(numbers, 4));
        }

        private static bool Contains(List<int> list, int number)
        {
            return list.Contains(number);
        }

        private static int LinearSearch(List<int> list, int number)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] == number)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
