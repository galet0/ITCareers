using System;

namespace _02_DefineClassGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Geometry.SquarePerimeter(2));
            Console.WriteLine(Geometry.SquareArea(4));
            Console.WriteLine(Geometry.RectanglePerimeter(2, 4));
            Console.WriteLine(Geometry.RectangleArea(2, 4));
            Console.WriteLine(Geometry.CircleArea(3));
        }
    }
}
