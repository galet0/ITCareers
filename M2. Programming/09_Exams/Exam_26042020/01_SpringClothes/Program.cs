using System;

namespace _01_SpringClothes
{
    class Program
    {
        static void Main(string[] args)
        {
            int clothesCount = int.Parse(Console.ReadLine());
            double totalSum = 0;

            for (int i = 0; i < clothesCount; i++)
            {
                string clothes = Console.ReadLine();

                switch (clothes)
                {
                    case "t-shirt":
                        totalSum += 20;
                        break;
                    case "jeans":
                        totalSum += 50;
                        break;
                    case "trainers":
                        totalSum += 70;
                        break;
                    case "jacket":
                        totalSum += 60;
                        break;
                }
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
