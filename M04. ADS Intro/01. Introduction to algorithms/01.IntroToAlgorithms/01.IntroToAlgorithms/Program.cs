using System;

namespace _01.IntroToAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(50));
        }

        static int Fibonacci(int n)
        {
            if (n == 0) return 1;
            else if (n == 1) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
