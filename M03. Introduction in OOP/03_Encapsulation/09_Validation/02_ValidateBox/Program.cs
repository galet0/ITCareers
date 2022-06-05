using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _02_ClassBox
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            try
            {
                Box box = new Box(length, width, height);

                Console.WriteLine($"Surface Area – {box.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume – {box.Volume():f2}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
