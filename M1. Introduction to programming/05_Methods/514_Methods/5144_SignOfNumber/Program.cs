using System;

namespace _5144_SignOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double number = double.Parse(Console.ReadLine());
                string result = NumberSign(number);
                Console.WriteLine($"The number {number} is {result}.");
            }
        }

        static string NumberSign(double number)
        {
            if(number < 0)
            {
                return "negative";
            }
            else if(number > 0)
            {
                return "positive";
            }
            else
            {
                return "zero";
            }
        } 
    }
}
