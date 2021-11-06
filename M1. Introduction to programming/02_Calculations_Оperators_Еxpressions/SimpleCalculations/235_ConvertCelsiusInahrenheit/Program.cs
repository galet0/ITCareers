using System;

namespace _235_ConvertCelsiusInahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine(Math.Round(fahrenheit, 2));
        }
    }
}
