using System;
using System.Diagnostics;
using System.Text;

namespace _00_ConcatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            timer.Start();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 50000; i++)
                result.Append(Convert.ToString(i, 2));
            Console.WriteLine(result.Length);
            Console.WriteLine(timer.Elapsed); //734466 00:00:11.8799451 string
                                              //734466 00:00:00.0169152 StringBuilder

        }
    }
}
