using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_ModaOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            Dictionary<double, int> dict = new Dictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!dict.ContainsKey(array[i]))
                {
                    dict.Add(array[i], 0);
                }

                dict[array[i]]++;
            }

            int max = int.MinValue;
            double value = 0;

            foreach (var item in dict)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    value = item.Key;
                }
            }


            var result = dict.Where(x => x.Value == max)
                .Select(x => x.Key);
                //.Sum()/max;

            if(result.Count() > 1)
            {
                value = result.Sum() / max;
            }

            Console.WriteLine(value);

        }
    }
}
