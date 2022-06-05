using System;

namespace _01_DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double dailyProfit = double.Parse(Console.ReadLine());
            double dollarCourse = double.Parse(Console.ReadLine());

            double monthlySalary = workingDays * dailyProfit;
            double yearlyProfit = monthlySalary * 12 + monthlySalary * 2.5;
            double netAnnualIncome = (yearlyProfit - yearlyProfit * 0.25)*dollarCourse;
            double dailyIncomeBG = netAnnualIncome / 365;

            Console.WriteLine($"{dailyIncomeBG:f2}");
        }
    }
}
