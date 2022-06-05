using System;

namespace _350_IfElse_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;
            Console.WriteLine(a < b);      // True
            Console.WriteLine(a > 0);      // True
            Console.WriteLine(a > 100);    // False
            Console.WriteLine(a < a);      // False
            Console.WriteLine(a <= 5);     // True
            Console.WriteLine(b == 2 * a); // True
        }
    }
}
