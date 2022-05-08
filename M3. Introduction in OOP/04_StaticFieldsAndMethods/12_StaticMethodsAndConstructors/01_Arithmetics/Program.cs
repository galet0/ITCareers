using System;

namespace _01_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            double add = Arithmetic.Addition(2, 5);
            Console.WriteLine(add);

            double product = Arithmetic.Multiplication(2, 5);
            Console.WriteLine(product);
        }
    }

    static class Arithmetic
    {
        public static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
