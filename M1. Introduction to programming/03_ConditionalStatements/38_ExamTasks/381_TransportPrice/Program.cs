using System;

namespace _381_TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0;

            if (km < 20)
            {
                //taxi
                if (dayOrNight.Equals("day"))
                {
                    price = km * 0.79 + 0.7;
                }
                else if (dayOrNight.Equals("night"))
                {
                    price = km * 0.9 + 0.7;
                }
            }
            else if (km < 100)
            {
                //bus
                price = km * 0.09;
            }
            else
            {
                //train
                price = km * 0.06;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
