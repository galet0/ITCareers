using System;

namespace _197_RaiseToPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RaiseToPower(2, 8));
        }
        static double RaiseToPower(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

    }
}
