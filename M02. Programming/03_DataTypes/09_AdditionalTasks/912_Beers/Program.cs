using System;

namespace _912_Beers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = int.MinValue;
            string maxVolumeModel = null;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if(volume > maxVolume)
                {
                    maxVolume = volume;
                    maxVolumeModel = model;
                }
            }

            Console.WriteLine($"{maxVolumeModel}");
        }
    }
}
