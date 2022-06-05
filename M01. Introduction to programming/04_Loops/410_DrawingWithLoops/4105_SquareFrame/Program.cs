using System;

namespace _4105_SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintLine(n, '+');
            for (int i = 0; i < n-2; i++)
            {
                PrintLine(n, '|');
            }
            PrintLine(n, '+');
        }

        static void PrintLine(int n, char sign)
        {
            Console.Write(sign);
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine($" {sign}");
        }
    }
}
