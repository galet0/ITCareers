using System;

namespace _03_HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studio = 50;
                    apartment = 65;
                    if(nightsCount > 14)
                    {
                        studio -= studio * 0.30;
                    }
                    else if(nightsCount > 7)
                    {
                        studio -= studio * 0.05;
                    }
                    break;
                case "June":
                case "September":
                    studio = 75.20;
                    apartment = 68.70;
                    if (nightsCount > 14)
                    {
                        studio -= studio * 0.20;
                    }
                    break;
                case "July":
                case "August":
                    studio = 76;
                    apartment = 77;
                    break;
            }

            if(nightsCount > 14)
            {
                apartment -= apartment * 0.1;
            }

            double totalApartment = apartment * nightsCount;
            double totalStudio = studio * nightsCount;
            Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
        }
    }
}
