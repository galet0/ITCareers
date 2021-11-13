using System;

namespace _232_InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Inches = ");
            double inches = double.Parse(Console.ReadLine());

            double centimeters = inches * 2.54;
            Console.WriteLine($"{centimeters} cm");
        }
    }
}
