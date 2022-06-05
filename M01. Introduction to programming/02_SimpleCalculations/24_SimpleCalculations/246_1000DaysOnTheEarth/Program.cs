using System;
using System.Globalization;

namespace _246_1000DaysOnTheEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string date = Console.ReadLine();
                string format = "dd-MM-yyyy";
                CultureInfo provider = CultureInfo.InvariantCulture;

                DateTime dateTime = DateTime.ParseExact(date, format, provider).AddDays(999);
                Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));
            }
        }
    }
}
