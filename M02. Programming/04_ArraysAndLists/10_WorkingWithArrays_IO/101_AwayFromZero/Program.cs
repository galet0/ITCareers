using System;
using System.Linq;

namespace _101_AwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {Math.Round(nums[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
