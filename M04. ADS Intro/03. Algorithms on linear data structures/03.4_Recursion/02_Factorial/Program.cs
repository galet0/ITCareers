using System;

namespace _02_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            long result = FactorialRecursion(n);
            Console.WriteLine(result);
        }

        static long FactorialRecursion(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * FactorialRecursion(num - 1);
        }

        static long FactorialIteration(int num)
        {
            long result = 1;
            for (int i = 1; i <= num; i++)
                result *= i;
            return result;
        }
    }
}
