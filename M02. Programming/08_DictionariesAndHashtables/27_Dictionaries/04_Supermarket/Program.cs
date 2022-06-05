using System;
using System.Collections.Generic;

namespace _04_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> store = new Dictionary<string, double[]>();

            string line = Console.ReadLine();

            while (line != "stocked")
            {
                string[] info = line.Split();
                //  0    1   2
                //Beer 2.20 100

                if (!store.ContainsKey(info[0]))
                {
                    store.Add(info[0], new double[2]);
                }
                //store["Beer"][0] = 2.20
                store[info[0]][0] = double.Parse(info[1]);
                //store["Beer"][1] = 100
                store[info[0]][1] += double.Parse(info[2]);

                line = Console.ReadLine();
            }

            //Beer: $2.20 * 100 = $220.00
            double grandTotal = 0;
            foreach (var product in store)
            {
                double productSum = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key}: ${product.Value[0]:f2} * {product.Value[1]} = ${productSum:f2}");
                grandTotal += productSum;
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
