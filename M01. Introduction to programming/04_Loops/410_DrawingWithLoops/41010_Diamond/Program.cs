using System;

namespace _41010_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dashes = (n - 1) / 2;

            Console.Write(new string('-', dashes));
            Console.Write(new string('*', n - (dashes * 2)));
            Console.WriteLine(new string('-', dashes));

            for (int i = 0; i < (n-1)/2; i++)
            {
                Console.Write(new string('-', dashes - i - 1));
                Console.Write('*');
                Console.Write(new string('-', i * 2 + n - (dashes * 2)));
                Console.Write('*');
                Console.WriteLine(new string('-', dashes - i - 1));
            }

            for (int i = (n - 1) / 2; i > 1; i--)
            {
                Console.Write(new string('-', dashes - i + 1));
                Console.Write('*');
                Console.Write(new string('-',n - (dashes - i + 1)*2 - 2));
                Console.Write('*');
                Console.WriteLine(new string('-', dashes - i + 1));
            }

            Console.Write(new string('-', dashes));
            Console.Write(new string('*', n - (dashes * 2)));
            Console.WriteLine(new string('-', dashes));
        }
    }
}
