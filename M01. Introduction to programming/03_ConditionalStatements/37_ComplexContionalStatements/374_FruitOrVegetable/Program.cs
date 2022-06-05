using System;

namespace _374_FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string product = Console.ReadLine();
                if (product.Equals("end"))
                {
                    break;
                }

                if(product.Equals("banana")
                    || product.Equals("apple")
                    || product.Equals("kiwi")
                    || product.Equals("cherry")
                    || product.Equals("lemon")
                    || product.Equals("grapes"))
                {
                    Console.WriteLine($"{product} is a Fruit!");
                }
                else if (product.Equals("tomato")
                    || product.Equals("cucumber")
                    || product.Equals("pepper")
                    || product.Equals("carrot"))
                {
                    Console.WriteLine($"{product} is a Vegetable!");
                }
                else
                {
                    Console.WriteLine("Unknown product!");
                }
            }
        }
    }
}
