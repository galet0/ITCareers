using System;

namespace _372_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string product = Console.ReadLine();
                string city = Console.ReadLine();
                double quantity = double.Parse(Console.ReadLine());
                double price = 0;

                if (city.Equals("Sofia"))
                {
                    if (product.Equals("coffee"))
                    {
                        price = quantity * 0.5;
                    }
                    else if (product.Equals("water"))
                    {
                        price = quantity * 0.8;
                    }
                    else if (product.Equals("beer"))
                    {
                        price = quantity * 1.2;
                    }
                    else if (product.Equals("sweets"))
                    {
                        price = quantity * 1.45;
                    }
                    else if (product.Equals("peanuts"))
                    {
                        price = quantity * 1.60;
                    }
                }
                else if (city.Equals("Plovdiv"))
                {
                    if (product.Equals("coffee"))
                    {
                        price = quantity * 0.4;
                    }
                    else if (product.Equals("water"))
                    {
                        price = quantity * 0.7;
                    }
                    else if (product.Equals("beer"))
                    {
                        price = quantity * 1.15;
                    }
                    else if (product.Equals("sweets"))
                    {
                        price = quantity * 1.3;
                    }
                    else if (product.Equals("peanuts"))
                    {
                        price = quantity * 1.5;
                    }
                }
                else if (city.Equals("Varna"))
                {
                    if (product.Equals("coffee"))
                    {
                        price = quantity * 0.45;
                    }
                    else if (product.Equals("water"))
                    {
                        price = quantity * 0.7;
                    }
                    else if (product.Equals("beer"))
                    {
                        price = quantity * 1.1;
                    }
                    else if (product.Equals("sweets"))
                    {
                        price = quantity * 1.35;
                    }
                    else if (product.Equals("peanuts"))
                    {
                        price = quantity * 1.55;
                    }
                }

                Console.WriteLine(price);
            }
        }
    }
}
