using System;
using System.Collections.Generic;

namespace _03_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //S = 3, 4, 6, 5, 8, 7, 12, 6, 10, 9, 16, 8, 14, …
            //S = N, N+1, 2*N, N+2, 2*(N+1), 2*N+1, 4*N, …

            int n = 3;
            int p = 17;

            //3
            //3 + 1
            //2 * 3

            //3 + 1 + 1
            //(3 + 1) * 2

            //2 * 3 + 1

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int index = 0;
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                index++;
                if (current == p)
                {
                    Console.WriteLine("Index = {0}", index);
                    break;
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }
        }
    }
}
