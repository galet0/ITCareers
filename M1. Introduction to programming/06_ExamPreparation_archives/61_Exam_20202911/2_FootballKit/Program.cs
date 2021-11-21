using System;

namespace _2_FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sumToWinBall = double.Parse(Console.ReadLine());

            double shortsPrice = tshirtPrice * 0.75;
            double socks = shortsPrice * 0.20;
            double buttons = 2 * (tshirtPrice + shortsPrice);

            double moneySpent = tshirtPrice + shortsPrice + socks + buttons;
            double withDiscount = moneySpent - moneySpent * 0.15;

            if(withDiscount >= sumToWinBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {withDiscount:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(sumToWinBall - withDiscount):f2} lv. more.");
            }
        }
    }
}
