using System;
using System.Collections.Generic;

namespace _08_ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
