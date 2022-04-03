using System;

namespace _194_PrintSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeaderRow(4);
            for (int i = 0; i < 4; i++)
            {
                PrintMiddle(4);
            }
            PrintHeaderRow(4);
        }

        static void PrintMiddle(int n)
        {
            // -\/\/\/-
            Console.Write($"-");
            for (int i = 0; i < (n * 2 - 2) / 2; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine($"-");
        }
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

    }
}
