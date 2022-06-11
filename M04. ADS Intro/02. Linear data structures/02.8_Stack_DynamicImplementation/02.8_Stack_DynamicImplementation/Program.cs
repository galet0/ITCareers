using System;

namespace _02._8_Stack_DynamicImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack<int> stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.Pop());

            int[] array = stack.ToArray();
            Console.WriteLine(string.Join(", ", array));

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Contains(5));
            Console.WriteLine(stack.Contains(3));

            stack.Clear();
        }
    }
}
