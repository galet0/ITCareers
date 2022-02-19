using System;

namespace _065_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSeconds = seconds + (minutes * 60) + hours * 60 * 60;

            float vms = meters / totalSeconds;
            float vkmh = (meters / 1000) / (totalSeconds / 3600);
            float vmh = (meters/1609) / (totalSeconds / 3600);
            Console.WriteLine(Math.Round(vms, 7));
            Console.WriteLine(Math.Round(vkmh, 7));
            Console.WriteLine(Math.Round(vmh, 7));
        }
    }
}
