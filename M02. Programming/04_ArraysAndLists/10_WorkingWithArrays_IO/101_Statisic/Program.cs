using System;
using System.Linq;

namespace _101_Statisic
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 3 4 5 6 1
            int[] nums = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int min = FindMin(nums);
            int max = FindMax(nums);
            double sum = FindSum(nums);
            double avg = sum / nums.Length;

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Avg = {avg}");
        }

        public static int FindMin(int[] nums)
        {
            int min = nums[0]; //2
            for (int i = 1; i < nums.Length; i++)
            {
                //1 2 3 4 5
                //3 4 5 6 1
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            return min;
        }

        public static int FindMax(int[] nums)
        {
            int max = nums[0]; //2
            for (int i = 1; i < nums.Length; i++)
            {
                //1 2 3 4 5
                //3 4 5 6 1
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            return max;
        }

        public static double FindSum(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }
    }
}
