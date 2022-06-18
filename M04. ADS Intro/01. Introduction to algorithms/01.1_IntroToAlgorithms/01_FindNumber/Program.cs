using System;
using System.Collections.Generic;

namespace _01_FindNumber
{
    class Program
    {
        static List<int> list = new List<int>() { 12, 8, 56, 4, 9, 78, 13, 54, 10, 0, -78, -45, 32 };
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = NumberExistInTheList(number);

            Console.WriteLine(result);
        }

        static int NumberExistInTheList(int number)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(number == list[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
