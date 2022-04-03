using System;
using System.Collections.Generic;
using System.Linq;

namespace _00_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>{ 1, 5, 2, 4, 3 };

            List<int> ascSorted = nums.OrderBy(n => n).ToList();

            //Console.WriteLine(string.Join(" ", ascSorted));

            List<int> descSorted = nums.OrderByDescending(n => n).ToList();
            
            //Console.WriteLine(string.Join(" ", descSorted));

            List<int> takeList = nums.Take(2).ToList();
            Console.WriteLine(string.Join(" ", takeList));

            List<int> takeLast = nums.TakeLast(2).ToList();
            Console.WriteLine(string.Join(" ", takeLast));

            List<int> skipFirst = nums.Skip(2).ToList();
            Console.WriteLine(string.Join(" ", skipFirst));

            List<int> skipLast = nums.SkipLast(2).ToList();
            Console.WriteLine(string.Join(" ", skipLast));

            List<int> skipTake = nums.Skip(2).Take(2).ToList();
            Console.WriteLine(string.Join(" ", skipTake));
        }
    }
}
