using System;

namespace _4134_Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            //ширина 2 * n - 1 колони 
            //височина 2 * (n - 2) + 1  
            //Лявата и дясната ѝ част са широки n - 1.

            int n = int.Parse(Console.ReadLine());

            int height = 2 * (n - 2) + 1;
            int width = 2 * n - 1;
            int leftRight = n - 1;

            for (int i = 0; i < height / 2; i++)
            {
                if(i % 2 == 0)
                {
                    PrintLine(width, '*', '\\', '/');
                }
                else
                {
                    PrintLine(width, '-', '\\', '/');
                }
            }
            Console.WriteLine(new string(' ', n-1) + "@");
            for (int i = 0; i < height / 2; i++)
            {
                if (i % 2 == 0)
                {
                    PrintLine(width, '*', '/', '\\');
                }
                else
                {
                    PrintLine(width, '-', '/', '\\');
                }
            }
        }

        private static void PrintLine(int width, char sign, char left, char right)
        {
            Console.Write(new string(sign, width / 2 - 1));
            Console.Write($"{left} {right}");
            Console.WriteLine(new string(sign, width / 2 - 1));
        }
    }
}
