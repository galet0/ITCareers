﻿using System;

namespace _910_SignSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char sign = char.Parse(Console.ReadLine());

                sum += sign;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
