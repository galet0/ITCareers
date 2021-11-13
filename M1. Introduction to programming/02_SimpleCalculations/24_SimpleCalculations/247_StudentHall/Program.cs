using System;

namespace _247_StudentHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            int length = (int)(h * 100);
            int width = (int)(w * 100);

            int rows = length / 120;
            int desks = (width - 100) / 70;

            int placesCount = rows * desks - 3;

            Console.WriteLine(placesCount);
                
        }
    }
}
