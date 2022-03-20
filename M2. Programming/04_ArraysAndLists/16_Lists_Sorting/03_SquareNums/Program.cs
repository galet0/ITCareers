using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SquareNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> squareNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if(Math.Sqrt(nums[i]) == (int)Math.Sqrt(nums[i]))
                {
                    squareNums.Add(nums[i]);
                }
            }

            squareNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",squareNums));
        }
    }
}
