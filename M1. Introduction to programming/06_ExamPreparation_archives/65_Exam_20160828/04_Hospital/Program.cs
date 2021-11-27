using System;

namespace _04_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treated = 0;
            int untreated = 0;

            for (int day = 1; day <= days; day++)
            {
                int patientsCount = int.Parse(Console.ReadLine());

                if(day % 3 == 0 && untreated > treated)
                {
                    doctors++;
                }

                if(patientsCount <= doctors)
                {
                    treated += patientsCount;
                }
                else 
                {
                    treated += doctors;
                    untreated += (patientsCount - doctors);
                }
            }

            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
