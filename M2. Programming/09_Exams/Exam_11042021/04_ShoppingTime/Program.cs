using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_ShoppingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string shopping = Console.ReadLine();
            Dictionary<string, double> shoppingCart = new Dictionary<string, double>();

            while (shopping != "Stop shopping")
            {
                string[] product = shopping.Split("-");

                if (!shoppingCart.ContainsKey(product[0]))
                {
                    shoppingCart.Add(product[0], 0);
                }

                shoppingCart[product[0]] += double.Parse(product[1]);
                shopping = Console.ReadLine();
            }

            foreach (var item in shoppingCart.OrderBy(p => p.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

            Console.WriteLine($"Total sum: {shoppingCart.Sum(x => x.Value):f2}");
        }
    }
}
