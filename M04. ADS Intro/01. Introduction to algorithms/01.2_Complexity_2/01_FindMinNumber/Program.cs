using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_FindMinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int min = nums[0];

            for (int i = 1; i < nums.Count; i++)
            {
                if(nums[i] < min)
                {
                    min = nums[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
