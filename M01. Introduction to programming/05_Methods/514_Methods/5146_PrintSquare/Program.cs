using System;

namespace _5146_PrintSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddle(n);
            }
            PrintHeaderRow(n);
        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddle(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine('-');
        }
    }
}
