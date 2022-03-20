using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_RemoveNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split()
                .Select(int.Parse)
                .Where(n => n > 0)
                .Reverse()
                .ToList();

            Console.WriteLine(nums.Count > 0 ? string.Join(" ", nums) : "empty");

            //Вариант 2:
            //List<int> resultList = new List<int>();

            //for (int i = nums.Count - 1; i >= 0; i--)
            //{
            //    if(nums[i] > 0)
            //    {
            //        resultList.Add(nums[i]);
            //    }
            //}

            //Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
