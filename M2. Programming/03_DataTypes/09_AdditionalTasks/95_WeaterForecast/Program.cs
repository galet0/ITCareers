using System;

namespace _95_WeaterForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            sbyte sbyteResult;
            int intResult;
            long longResult;

            if(sbyte.TryParse(num, out sbyteResult))
            {
                Console.WriteLine("Sunny");
            }
            else if (int.TryParse(num,out intResult))
            {
                Console.WriteLine("Cloudy");
            }
            else if(long.TryParse(num,out longResult))
            {
                Console.WriteLine("Windy");
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
