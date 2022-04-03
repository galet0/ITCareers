using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ThreeBiggestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> biggest3 = list.OrderByDescending(x => x)
                .Take(3).ToList();

            Console.WriteLine(string.Join(" ", biggest3));
        }
    }
}
