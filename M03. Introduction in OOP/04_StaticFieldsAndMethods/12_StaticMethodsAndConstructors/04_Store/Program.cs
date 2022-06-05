using System;

namespace _04_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //string barcode, string name, double price, int quantity
            string[] input = Console.ReadLine().Split();

            while(input[0] != "Close")
            {
                switch (input[0])
                {
                    case "Add":
                        Product product = new Product(input[1], input[2], double.Parse(input[3]), double.Parse(input[4]));
                        Store.Add(product);
                        break;
                    case "Sell":
                        Store.Sell(input[1], double.Parse(input[2]));
                        break;
                    case "Update":
                        Store.Update(input[1], double.Parse(input[2]));
                        break;
                    case "PrintA":
                        Store.PrintAvailableProductsByName();
                        break;
                    case "PrintU":
                        Store.PrintUnavailableProductsByName();
                        break;
                    case "PrintD":
                        Store.PrintProductsByDescQuantity();
                        break;
                    case "Calculate":
                        Console.WriteLine($"{Store.Calculate():f2}");
                        break;
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}
