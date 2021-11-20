using System;

namespace _4109_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //TO DO
            int n = int.Parse(Console.ReadLine());
            //
            int odd = 1;
            int even = 2;

            if(n % 2 == 0)
            {
                Console.Write(new string('-', (n-2)/2));
                Console.Write(new string('*', even));
                Console.WriteLine(new string('-', (n - 2) / 2));

                for (int i = 1; i < (n + 1) / 2; i++)
                {
                    Console.Write(new string('-', (n - 2) / 2 - i));
                    Console.Write(new string('*', even + i * 2));
                    Console.WriteLine(new string('-', (n - 2) / 2 - i));
                }
            }
            else
            {
                Console.Write(new string('-', (n - 1) / 2));
                Console.Write(new string('*', odd));
                Console.WriteLine(new string('-', (n - 1) / 2));

                for (int i = 1; i < (n + 1) / 2; i++)
                {
                    Console.Write(new string('-', (n - 1) / 2 - i));
                    Console.Write(new string('*', even + i * 2-1));
                    Console.WriteLine(new string('-', (n - 1) / 2 - i));
                }
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n-2));
                Console.WriteLine('|');
            }
        }
    }
}
