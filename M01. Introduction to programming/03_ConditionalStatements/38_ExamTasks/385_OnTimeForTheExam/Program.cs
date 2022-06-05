using System;

namespace _385_OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrivedH = int.Parse(Console.ReadLine());
            int arrivedM = int.Parse(Console.ReadLine());

            int exam = examH * 60 + examM;
            int arrived = arrivedH * 60 + arrivedM;

            //570min exam start
            //590min arrived late

            int diff = Math.Abs(arrived - exam);
            int h = diff / 60;
            int m = diff % 60;
            string result = "";
            if (arrived > exam)
            {
                //late
                Console.WriteLine("Late");
                result = "after the start";
            }
            else if (exam >= arrived && (exam - arrived) <= 30)
            {
                //540 510 < 30 on time
                Console.WriteLine("On time");
                if (exam > arrived)
                {
                    result = "before the start";
                }
                
            }
            else
            {
                //960 900 early 
                Console.WriteLine("Early");
                result = "before the start";
            }

            if (!(exam == arrived))
            {
                if (h == 0)
                {
                    Console.WriteLine($"{m} minutes {result}");
                }
                else
                {
                    Console.WriteLine(m < 10 ? $"{h}:0{m} hours {result}" : $"{h}:{m} hours {result}");
                }
            }
        }
    }
}
