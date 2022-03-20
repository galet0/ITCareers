using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_RemoveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int last = nums[nums.Count - 1];
            //Вариант 1:
            //int removedCount = nums.RemoveAll(n => n == last);
            //Console.WriteLine(removedCount);

            //Вариант 2:
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    if(nums[i] == last)
            //    {
            //        nums.Remove(nums[i]);
            //        i--;
            //    }
            //}

            //Вариант 3:
            while (nums.Contains(last))
            {
                nums.Remove(last);
            }       
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
