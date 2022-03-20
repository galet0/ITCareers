using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_InputOneLine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"nums[{i}] = {numbers[i]}");
            }
        }
    }
}
