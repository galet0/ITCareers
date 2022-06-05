using System;

namespace _04_DiffBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            Console.WriteLine(DateModifier.CalculateDifference(date1, date2));
        }
    }
}
