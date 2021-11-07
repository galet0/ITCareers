using System;

namespace _242_PerimeterAndAreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(r, 2);
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine($"Area = {Math.Round(area, 2)}");
            Console.WriteLine($"Perimeter = {Math.Round(perimeter, 2)}");
        }
    }
}
