using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MaxSequenceEqualsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //0 1 2 3 4 5 6 7
            //3 4 4 5 5 5 2 2
            int bestStart = 0;
            int bestLength = 1;
            int currentLength = 1;
            int index = 0;
            int first = nums[index];

            for (int i = 1; i < nums.Count; i++)
            {
                if(first == nums[i])
                {
                    currentLength++;
                    if(currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStart = index;
                    }
                }
                else
                {
                    first = nums[i];
                    index = i;
                    currentLength = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}
