using System;
using System.Collections.Generic;

namespace _02_CalcSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(n);
            int position = 1;
            int current = 0;
            //3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, …
            //2 
            while (position <= 50)
            {
                current = queue.Dequeue();
                Console.Write($"{current} ");
                position++;

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }
        }
    }
}
