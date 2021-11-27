using System;

namespace _03_WimbeldonTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string etap = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());
            double ticketPrice = 0;

            if (etap.Equals("Quarter final"))
            {
                if (ticketType.Equals("Standard"))
                {
                    ticketPrice = 55.50;
                }
                else if (ticketType.Equals("Premium"))
                {
                    ticketPrice = 105.20;
                }
                else if (ticketType.Equals("VIP"))
                {
                    ticketPrice = 118.90;
                }
            }
            else if(etap.Equals("Semi final"))
            {
                if (ticketType.Equals("Standard"))
                {
                    ticketPrice = 75.88;
                }
                else if (ticketType.Equals("Premium"))
                {
                    ticketPrice = 125.22;
                }
                else if (ticketType.Equals("VIP"))
                {
                    ticketPrice = 300.40;
                }
            }
            else if (etap.Equals("Final"))
            {
                if (ticketType.Equals("Standard"))
                {
                    ticketPrice = 110.10;
                }
                else if (ticketType.Equals("Premium"))
                {
                    ticketPrice = 160.66;
                }
                else if (ticketType.Equals("VIP"))
                {
                    ticketPrice = 400;
                }
            }

            double total = ticketPrice * ticketsCount;
            bool freePictures = false;

            if(total > 4000)
            {
                freePictures = true;
                total = total - total * 0.25;
            }
            else if(total > 2500)
            {
                total = total - total * 0.1;
            }

            if(picture == 'Y' && !freePictures)
            {
                total += ticketsCount * 40;
            }

            Console.WriteLine($"{total:f2}");
        }

    }
}
