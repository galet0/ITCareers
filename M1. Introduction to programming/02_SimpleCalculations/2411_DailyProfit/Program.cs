using System;

namespace _2411_DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double dollarCourse = double.Parse(Console.ReadLine());

            double monthlyProfit = days * moneyPerDay;//monthly
            double yearlyProfit = (monthlyProfit * 12) + monthlyProfit * 2.5; //yearly

            double vat = yearlyProfit * 0.25;
            double clearProfit = (yearlyProfit - vat) * dollarCourse;
            double result = clearProfit / 365;

            Console.WriteLine($"{result:f2}");
        }
    }
}
