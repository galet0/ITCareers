using System;
using System.Collections.Generic;

namespace _02._3_CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue<int> queue = new CircularQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);

            Console.WriteLine(queue.Dequeue());

            int[] arr = queue.ToArray();
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
