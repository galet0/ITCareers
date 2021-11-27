using System;

namespace _03_ChristmasHolyday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string roomType = Console.ReadLine();

            double roomPrice = 0;

            if (destination.Equals("Borovets"))
            {
                switch (roomType)
                {
                    case "double":
                        roomPrice = 38;
                        break;
                    case "apartment":
                        roomPrice = 45;
                        break;
                }
            }
            else if (destination.Equals("Bansko"))
            {
                switch (roomType)
                {
                    case "double":
                        roomPrice = 35;
                        break;
                    case "apartment":
                        roomPrice = 42;
                        break;
                }
            }
            else if (destination.Equals("Pamporovo"))
            {
                switch (roomType)
                {
                    case "double":
                        roomPrice = 39;
                        break;
                    case "apartment":
                        roomPrice = 49;
                        break;
                }
            }

            double total = days * roomPrice;

            if(days > 10)
            {
                total = total - total * 0.15;
            }

            Console.WriteLine($"They have to spend {total:f2} leva.");
        }
    }
}
