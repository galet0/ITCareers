using System;

namespace _367_FiguresAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string figure = Console.ReadLine();
                double area = 0;

                if (figure.Equals("square"))
                {
                    double side = double.Parse(Console.ReadLine());
                    area = Math.Pow(side, 2);// side * side;
                }
                else if (figure.Equals("rectangle"))
                {
                    double sideA = double.Parse(Console.ReadLine());
                    double sideB = double.Parse(Console.ReadLine());
                    area = sideA * sideB;
                }
                else if (figure.Equals("circle"))
                {
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(radius, 2);
                }
                else if (figure.Equals("triangle"))
                {
                    double a = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    area = a * h / 2;
                }

                Console.WriteLine($"{Math.Round(area, 3)}");
            }
        }
    }
}
