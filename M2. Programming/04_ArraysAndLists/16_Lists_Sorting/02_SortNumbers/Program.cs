using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            list.Sort();
            Console.WriteLine(string.Join(" <= ", list));
        }
    }
}
