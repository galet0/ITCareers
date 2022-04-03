using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(",").Select(int.Parse).ToList();

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            List<int> sum5 = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if(nums[i] % 2 == 0)
                {
                    evens.Add(nums[i]);
                }
                else
                {
                    odds.Add(nums[i]);
                }

                if(SumDigits(nums[i]) % 10 == 5)
                {
                    sum5.Add(nums[i]);
                }
            }

            Console.WriteLine(string.Join(", ", evens));
            Console.WriteLine(string.Join(", ", odds));
            Console.WriteLine(string.Join(", ", sum5));
        }

        static int SumDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
