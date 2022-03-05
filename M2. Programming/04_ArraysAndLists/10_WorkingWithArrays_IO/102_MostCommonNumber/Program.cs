using System;
using System.Linq;

namespace _102_MostCommonNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // 0 1 2
            // 4 1 1  4  2 3  4 4 1 2 4 9 3
            // 4 1 1 -1 2 3 -1 4 1 2 4 9 3
            int maxCount = 0;
            int maxElement = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                if(current == -1)
                {
                    continue;
                }
                int currentCount = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[j] != -1 && nums[j] == current)
                    {
                        currentCount++;
                        nums[j] = -1;
                    }
                    
                }
                //if (currentCount >= maxCount) // most right
                if(current > maxCount) // most left
                {
                    maxCount = currentCount;
                    maxElement = nums[i];
                }
            }

            Console.WriteLine($"Most common number is {maxElement} MaxCount = {maxCount}");
        }
    }
}
