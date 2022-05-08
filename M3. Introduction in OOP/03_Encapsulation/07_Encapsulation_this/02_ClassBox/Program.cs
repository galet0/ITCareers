using _01_SortPeopleByNameAndAge;
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

            Box box = new Box(length, width, height);

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            Console.WriteLine($"Surface Area – {box.SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume – {box.Volume():f2}");
            
        }
    }
}
