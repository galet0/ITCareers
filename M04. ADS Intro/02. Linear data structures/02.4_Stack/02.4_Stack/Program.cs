using System;
using System.Collections.Generic;

namespace _02._4_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            int[] array = stack.ToArray();
            Console.WriteLine(string.Join(", ", array));
            //Console.WriteLine(stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Contains(5));
            Console.WriteLine(stack.Contains(2));
            stack.Clear();

            Console.WriteLine();
        }
    }
}
