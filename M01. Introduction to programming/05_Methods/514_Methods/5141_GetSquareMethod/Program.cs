using System;

namespace _5141_GetSquareMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSquare(5.5);
            
        }

        static void Recursion()
        {
            Console.WriteLine("recursion....");
            Recursion();
        }
        static void PrintSquare(double num)
        {
            Console.WriteLine(GetSquare(num));
        }

        static double GetSquare(double a)
        {
            return a * a;
        }
    }
}
