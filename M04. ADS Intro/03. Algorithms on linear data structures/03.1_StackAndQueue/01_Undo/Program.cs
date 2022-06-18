using System;
using System.Collections.Generic;

namespace _01_Undo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            while (input != "exit")
            {
                if (input == "back")
                {
                    if(stack.Count != 1)
                    {
                        stack.Pop();
                        Console.WriteLine(stack.Peek());
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty!");
                    }
                }
                else
                {
                    stack.Push(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
