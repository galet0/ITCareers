using System;

namespace _05_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10)); // 89
            Console.WriteLine(Fibonacci(50)); // This will hang!
        }
        static decimal Fibonacci(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
