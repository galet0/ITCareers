using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Store
{
    static class Store
    {
        private static List<Product> products;

        static Store()
        {
            products = new List<Product>();
        }

        public static void Sell(string barcode, double quantity)
        {
            Product product = GetProduct(barcode);
            if (product == null || product.Quantity < quantity)
            {
                Console.WriteLine($"Not enough quantity");
            }
            else
            {
                product.Quantity -= quantity;
            }
        }


        public static void Add(Product product)
        {
            products.Add(product);
        }

        public static void Update(string barcode, double quantity)
        {
            Product product = GetProduct(barcode);
            if (product == null)
            {
                Console.WriteLine("Please add your product first!");
            }
            else
            {
                product.Quantity += quantity;
            }
        }

        public static void PrintAvailableProductsByName()
        {
            products.OrderBy(p => p.Name).ToList().ForEach(p => Console.WriteLine(p));
        }

        public static void PrintUnavailableProductsByName()
        {
            products.Where(p => p.Quantity < 1).OrderBy(p => p.Name).ToList().ForEach(p => Console.WriteLine(p));
        }

        public static void PrintProductsByDescQuantity()
        {
            products.OrderByDescending(p => p.Quantity).ToList().ForEach(p => Console.WriteLine(p));
        }

        public static double Calculate()
        {
            return products.Sum(p => (p.Price * p.Quantity));
        }
        private static Product GetProduct(string barcode)
        {
            return products.Where(p => p.Barcode == barcode).FirstOrDefault();
        }

    }
}
