using System;

namespace _02_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeed = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());


            double workingHours = (days - days * 0.1) * 8;
            double extraWork = employees * days * 2;

            double totalHoursWork = Math.Floor(workingHours + extraWork);
            
            if(totalHoursWork >= hoursNeed)
            {
                Console.WriteLine($"Yes!{totalHoursWork - hoursNeed} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeed - totalHoursWork} hours needed.");
            }
        }
    }
}
