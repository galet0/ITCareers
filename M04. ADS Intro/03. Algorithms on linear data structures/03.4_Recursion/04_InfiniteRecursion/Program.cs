using System;

namespace _04_InfiniteRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = Calculate(5);
            Console.WriteLine(result);
        }
        static long Calculate(int n)
        {
            return Calculate(n + 1);
        }

    }
}
