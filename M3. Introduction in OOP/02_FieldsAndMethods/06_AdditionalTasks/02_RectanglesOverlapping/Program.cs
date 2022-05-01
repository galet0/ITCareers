using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_RectanglesOverlapping
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] counts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < counts[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                Rectangle rectangle = new Rectangle(input[0], double.Parse(input[1]), double.Parse(input[2]), new Corner(double.Parse(input[3]), double.Parse(input[4])));

                rectangles.Add(rectangle); 
            }

            for (int i = 0; i < counts[1]; i++)
            {
                string[] pairs = Console.ReadLine().Split();
                Rectangle r1 = rectangles.Where(r => r.Id == pairs[0]).FirstOrDefault();
                Rectangle r2 = rectangles.Where(r => r.Id == pairs[1]).FirstOrDefault();

                bool result = r1.Overlap(r2);
                Console.WriteLine(result);
            }
        }
    }
}
