using System;
using System.Collections.Generic;

namespace _02.InsertMethod
{
    class Program
    {
        static List<int> list = new List<int>() { 1, 2, 5, 6, 8, 10, 12 };
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", list));

            Insert(number);

            Console.WriteLine(string.Join(" ", list));
        }

        static void Insert(int number)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(number >= list[i] && number <= list[i + 1])
                {
                    list.Insert(i + 1 , number);
                    break;
                }
            }
        }
    }
}
