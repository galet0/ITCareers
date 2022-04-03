using System;

namespace _03_PriceChangeAlert
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double border = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double div = PercentOfChange(lastPrice, currentPrice); 
                bool isSignificantDifference = HasDifference(div, border);

                string message = GetResult(currentPrice, lastPrice, div, isSignificantDifference);
                Console.WriteLine(message);
                lastPrice = currentPrice;
            }
        }

        private static string GetResult(double price, double last, double difference, bool hasDifference)
        {
            string result = "";
            if (difference == 0)
            {
                result = string.Format("NO CHANGE: {0}", price);
            }
            else if (!hasDifference)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, difference);
            }
            else if (hasDifference && (difference > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, difference);
            }
            else if (hasDifference && (difference < 0))
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, difference);
            return result;
        }
        private static bool HasDifference(double border, double difference)
        {
            if (Math.Abs(border) >= difference)
            {
                return true;
            }
            return false;
        }

        private static double PercentOfChange(double lastPrice, double currentPrice)
        {
            return (currentPrice - lastPrice) / lastPrice  * 100;
        }
    }

}
