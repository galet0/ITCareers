using System;
using System.Collections.Generic;

namespace _02._3_DynamicQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicQueue<int> queue = new DynamicQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());

            int[] arr = queue.ToArray();

            Console.WriteLine(string.Join(", ", arr));
            
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
