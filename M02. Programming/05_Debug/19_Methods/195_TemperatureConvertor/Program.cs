using System;

namespace _195_TemperatureConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FahrenheitToCelsius(20));
        }
        static double FahrenheitToCelsius(double degrees)
        {
            double celsius = (degrees - 32) * 5 / 9;
            return celsius;
        }
    }
}
