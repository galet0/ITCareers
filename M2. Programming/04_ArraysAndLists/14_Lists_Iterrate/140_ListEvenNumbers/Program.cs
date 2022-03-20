using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ListEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .ToList();

            //List<int> even = new List<int>();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if(numbers[i] % 2 == 0)
            //    {
            //        even.Add(numbers[i]);
            //    }
            //}

            Console.WriteLine(string.Join(" ", numbers));
            //Console.WriteLine(string.Join(" ", even));
        }
    }
}
