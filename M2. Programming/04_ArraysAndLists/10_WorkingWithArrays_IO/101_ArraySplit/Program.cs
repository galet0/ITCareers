using System;
using System.Linq;

namespace _101_ArraySplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 8 30 25 40 72 -2 44 56
            int[] array = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
        }
    }
}
