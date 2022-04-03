using System;

namespace _01_EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;

            for (int i = 0; i < eggsCount; i++)
            {
                string color = Console.ReadLine();
                if(color == "red")
                {
                    red++;
                }
                else if(color == "orange")
                {
                    orange++;
                }
                else if(color == "blue")
                {
                    blue++;
                }
                else if(color == "green")
                {
                    green++;
                }
            }

            int maxCount = int.MinValue;
            string maxColor = "";
            if(red > maxCount)
            {
                maxCount = red;
                maxColor = "red";
            }
            if(orange > maxCount)
            {
                maxCount = orange;
                maxColor = "orage";
            }
            if(blue > maxCount)
            {
                maxCount = blue;
                maxColor = "blue";
            }
            if(green > maxCount)
            {
                maxCount = green;
                maxColor = "green";
            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {maxCount} -> {maxColor}");
        }
    }
}
