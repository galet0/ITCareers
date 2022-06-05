using System;

namespace _196_TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetTriangleArea(2, 4));
        }

        static double GetTriangleArea(double width, double height)
        {
            double result = width * height / 2;
            return result;
        }
    }
}
