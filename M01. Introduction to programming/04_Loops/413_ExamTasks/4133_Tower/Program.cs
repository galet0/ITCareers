using System;

namespace _4133_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //n * 2 - (n/2 + 2)*2
            Console.WriteLine($@"/{new string('^', n/2)}\{new string('_', n * 2 - (n / 2 + 2) * 2)}/{new string('^', n / 2)}\");

            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine($"|{new string(' ', n * 2-2)}|");
            }

            Console.WriteLine($"|{new string(' ', n / 2 + 1)}{new string('_', n * 2 - (n / 2 + 2) * 2)}{new string(' ', n / 2 + 1)}|");
            Console.WriteLine($@"\{new string('_', n / 2)}/{new string(' ', n * 2 - (n / 2 + 2) * 2)}\{new string('_', n / 2)}/");
        }
    }
}
