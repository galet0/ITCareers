using System;

namespace _09_ArraysIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            //0..9
            //names[3] = "Stoicho";
            Console.WriteLine(nums.Length);
            //0 .. 9
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
                Console.WriteLine(nums[i]);
            }
        }
    }
}
