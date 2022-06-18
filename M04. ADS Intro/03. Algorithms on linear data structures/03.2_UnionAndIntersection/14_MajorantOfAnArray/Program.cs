using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_MajorantOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!dict.ContainsKey(array[i]))
                {
                    dict.Add(array[i], 0);
                }

                dict[array[i]]++;
            }

            bool hasMajorant = false;

            foreach (var item in dict)
            {
                if(item.Value == array.Length / 2 + 1)
                {
                    Console.WriteLine(item.Key);
                    hasMajorant = true;
                }
            }

            if (!hasMajorant)
            {
                Console.WriteLine("The majorant does not exists!");
            }
        }
    }
}
