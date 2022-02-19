using System;

namespace _914_BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int resultBoat1 = 0;
            int resultBoat2 = 0;

            for (int i = 1; i <= n; i++)
            {
                string line = Console.ReadLine();
                if(line == "UPGRADE")
                {
                    boat1 = (char)(boat1 + 3);
                    boat2 = (char)(boat2 + 3);
                    Console.WriteLine("Boat 1: " + boat1);
                    Console.WriteLine("Boat 2: " + boat2);
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        resultBoat1 += line.Length;
                    }
                    else
                    {
                        resultBoat2 += line.Length;
                    }
                }
                Console.WriteLine("result 1: " + resultBoat1);
                Console.WriteLine("result 2: " + resultBoat2);

                if (resultBoat1 >= 50 || resultBoat2 >= 50)
                {                    
                    break;
                }
            }

            Console.WriteLine(resultBoat1 > resultBoat2 ? boat1 : boat2);
        }
    }
}
