﻿using System;

namespace _231_SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double usdCourse = 1.79549;

            double bgn = usd * usdCourse;
            Console.WriteLine(Math.Round(bgn, 2) + " BGN");
        }
    }
}
