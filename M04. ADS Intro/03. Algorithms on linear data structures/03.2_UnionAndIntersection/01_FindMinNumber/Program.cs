using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_FindMinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
