using System;

namespace _4_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c2 = 0;
            int c3 = 0;
            int c5 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(number % 2 == 0)
                {
                    c2++;
                }
                if(number % 3 == 0)
                {
                    c3++;
                }
                if(number % 5 == 0)
                {
                    c5++;
                }
            }

            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c5);
        }
    }
}
