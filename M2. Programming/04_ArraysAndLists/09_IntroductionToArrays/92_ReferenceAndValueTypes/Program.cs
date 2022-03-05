using System;

namespace _92_ReferenceAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Increment(num, 15);
            Console.WriteLine(num);

            int[] nums = { 5 };
            Increment(nums, 15);
            Console.WriteLine(nums[0]);


            int[] a = new int[] { 1, 2, 3 };//0x000001E0D5B6B8E8
            int[] b = a;                    //0x000001E0D5B6B8E8

            b[0] = 5;
            Console.WriteLine(a[0]);

            int c = 5;
            int d = c;

            d = 10;
            Console.WriteLine(c);
        }

        private static void Increment(int[] nums, int value)
        {
            nums[0] += value;
        }

        private static void Increment(int num, int value)
        {
            num += value;
        }
    }
}
