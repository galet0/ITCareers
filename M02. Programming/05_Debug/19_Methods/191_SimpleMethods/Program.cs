using System;

namespace _191_SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {           
            Print("Hello");

            double result = GetSquare(4);
            Console.WriteLine(result);
            Console.WriteLine(GetSquare(5));

            Print("Hello");
            int r = Crash(5);
            Console.WriteLine(r);
        }

        static int Crash(int n)
        {
            if(n == 1)
            {
                return n;
            }
            return Crash(n-1);
        }
        static void Print(string message)
        {
            Console.WriteLine(GetSquare(8));
            Console.WriteLine(message);
        }
        static double GetSquare(double num)
        {
            return num * num;
        }
    }
}
