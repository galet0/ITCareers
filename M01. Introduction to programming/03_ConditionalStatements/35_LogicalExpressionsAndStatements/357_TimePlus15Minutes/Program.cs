using System;

namespace _357_TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if ((hours >= 0 && hours < 24) && (minutes >= 0 && minutes < 60))
            {
                //1 46
                minutes += 15;


                if (minutes > 59)
                {
                    hours++; // hours = hours + 1;
                    if (hours > 23)
                    {
                        hours -= 24;
                    }

                    minutes -= 60;//minutes = minutes - 60;
                }

                if (minutes < 10)
                {
                    Console.WriteLine($"{hours}:0{minutes}");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes}");
                }
            }
        }
    }
}
