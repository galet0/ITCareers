using System;

namespace _192_PrintSign
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSign(-5);
        }
        static void PrintSign(double num)
        {
            if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
