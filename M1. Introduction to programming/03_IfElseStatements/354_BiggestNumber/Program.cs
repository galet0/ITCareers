using System;

namespace _354_BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine($"a = {a}");
            }
            else
            {
                Console.WriteLine($"b = {b}");
            }
        }
    }
}
