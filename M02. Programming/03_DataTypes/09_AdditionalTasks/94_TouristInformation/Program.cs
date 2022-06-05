using System;

namespace _94_TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperial = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            string output = null;
            double result = 0;

            switch (imperial)
            {
                case "miles":
                    result = value * 1.6;
                    output = "kilometers";
                    break;
                case "inches":
                    result = value * 2.54;
                    output = "centimeters";
                    break;
                case "feet":
                    result = value * 30;
                    output = "centimeters";
                    break;
                case "yards":
                    result = value * 0.91;
                    output = "meters";
                    break;
                case "gallons":
                    result = value * 3.8;
                    output = "litters";
                    break;
            }

            Console.WriteLine($"{value} miles = {result:f2} {output}");
        }
    }
}
