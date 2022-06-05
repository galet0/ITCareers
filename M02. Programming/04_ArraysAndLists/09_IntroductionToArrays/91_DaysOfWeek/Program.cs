using System;

namespace _91_DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] days = new string[7];
            string[] days = {
                              "Monday",
                              "Tuesday",
                              "Wednesday",
                              "Thursday",
                              "Friday",
                              "Saturday",
                              "Sunday"
                            };

            int day = int.Parse(Console.ReadLine());//1..7

            //days[0] = "Monday";
            //days[1] = "Tuesday";
            //days[2] = "Wednesday";
            //days[3] = "Thursday";
            //days[4] = "Friday";
            //days[5] = "Saturday";
            //days[6] = "Sunday";
            if(day > 0 && day < 8)
            {
                Console.WriteLine(days[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
