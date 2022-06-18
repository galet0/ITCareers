using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_ReverseStack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                stack.Push(nums[i]);
            }

            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}
