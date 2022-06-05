using System;

namespace _5153_TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(side, height);
            Console.WriteLine(area);
        }

        static double GetTriangleArea(double side, double height)
        {
            return side * height / 2;
        }
    }
}
