using System;

namespace _4121_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fact = 1;

            do
            {
                fact = fact * n;
                n--;
            } while (n > 1);

            Console.WriteLine(fact);
        }
    }
}
