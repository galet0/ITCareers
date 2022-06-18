using System;
using System.Collections.Generic;

namespace _03_SequenseNM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int current = 0;

            while (queue.Count > 0)
            {
                current = queue.Dequeue();

                if(current >= m)
                {
                    break;
                }
                Console.Write($"{current} ");

                queue.Enqueue(current + 1);
                queue.Enqueue(current + 2);
                queue.Enqueue(current * 2);
            }

            Console.Write($"{m}");
        }
    }
}
