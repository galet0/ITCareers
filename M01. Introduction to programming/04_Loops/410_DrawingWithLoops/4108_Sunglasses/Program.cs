using System;

namespace _4108_Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //******
            //*////*
            //******
            PrintLine(n, '*', '*', ' ');
            for (int i = 0; i < n - 2; i++)
            {
                if(i == (n - 1) / 2 - 1)
                {
                    PrintLine(n, '*', '/', '|');
                }
                else
                {
                    PrintLine(n, '*', '/', ' ');
                }
            }
            PrintLine(n, '*', '*', ' ');

        }

        static void PrintLine(int n, char outerFrame, char middleSign, char middleFrame)
        {
            PrintGlass(n, outerFrame, middleSign);
            Console.Write(new string(middleFrame, n));
            PrintGlass(n, outerFrame, middleSign);
            Console.WriteLine();
        }

        static void PrintGlass(int n, char outerFrame, char middleSign)
        {
            Console.Write(outerFrame);
            Console.Write(new string(middleSign, n * 2 - 2));
            Console.Write(outerFrame);
        }
    }
}
