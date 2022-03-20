using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ListMinOrMaxNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int min = numbers.Min();
            int max = numbers.Max();

            List<int> sequence = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == min || numbers[i] == max)
                {
                    sequence.Add(numbers[i]);
                }
            }

            sequence.Sort();
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
