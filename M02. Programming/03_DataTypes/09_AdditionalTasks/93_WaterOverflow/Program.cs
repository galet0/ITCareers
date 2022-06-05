using System;

namespace _93_WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            byte maxCapacity = 0; 

            for (int i = 0; i < rows; i++)
            {
                int water = int.Parse(Console.ReadLine());

                if(maxCapacity + water <= byte.MaxValue)
                {
                    maxCapacity += (byte)water;
                    Console.WriteLine("current " + maxCapacity);
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(maxCapacity);
        }
    }
}
