using System;

namespace _02._7_DoublyLinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("After Dequeue");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Clear();
            Console.WriteLine(queue.Count);
        }
    }
}
