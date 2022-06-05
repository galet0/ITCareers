using System;

namespace _364_MetricsConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            if (from == "mm")
            {
                num = num / 1000m;
            }
            else if (from == "cm")
            {
                num = num / 100m;
            }
            else if (from == "mi")
            {
                num = num / 0.000621371192m;
            }
            else if (from == "in")
            {
                num = num / 39.3700787m;
            }
            else if (from == "km")
            {
                num = num / 0.001m;
            }
            else if (from == "ft")
            {
                num = num / 3.2808399m;
            }
            else if (from == "yd")
            {
                num = num / 1.0936133m;
            }

            if (to == "mm")
            {
                num = num * 1000m;
            }
            else if (to == "cm")
            {
                num = num * 100m;
            }
            else if (to == "mi")
            {
                num = num * 0.000621371192m;
            }
            else if (to == "in")
            {
                num = num * 39.3700787m;
            }
            else if (to == "km")
            {
                num = num * 0.001m;
            }
            else if (to == "ft")
            {
                num = num * 3.2808399m;
            }
            else if (to == "yd")
            {
                num = num * 1.0936133m;
            }
            Console.WriteLine($"{num} {to}");
        }
    }
}
