using System;

namespace _5152_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperature in Fahrenheit: ");
            double t = Double.Parse(Console.ReadLine());
            t = FahrenheitToCelsius(t);
            Console.Write("Temperature in Celsius: {0}", t);

        }

        private static double FahrenheitToCelsius(double degrees)
        {
            return (degrees - 32) * 5 / 9;
        }
    }
}
