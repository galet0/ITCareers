using System;

namespace _383_SleepingTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int tomsNorm = 30000;

            int dayOffPlay = days * 127;
            int workDaysPlay = (365 - days) * 63;
            int diff = Math.Abs(tomsNorm - (dayOffPlay + workDaysPlay));

            if(tomsNorm < (dayOffPlay+ workDaysPlay))
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{diff/60} hours and {diff%60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{diff/60} hours and {diff%60} minutes less for play");
            }
        }
    }
}
