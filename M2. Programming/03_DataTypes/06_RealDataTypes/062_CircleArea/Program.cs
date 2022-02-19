using System;

namespace _062_CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(Math.Round(area, 12));
            Console.WriteLine($"{area:f12}");
        }
    }
}
