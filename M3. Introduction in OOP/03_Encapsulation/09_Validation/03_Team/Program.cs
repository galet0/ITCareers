using _03_Team;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Shopping
{
    class Program
    {

        static List<Person> people = new List<Person>();
        static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            //Pesho=11;Gosho=4
            ReadPeople();

            //Bread = 10; Milk = 2;
            ReadProducts();

            ShoppingTime();
            Print();
        }

        private static void Print()
        {
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }

        private static void ShoppingTime()
        {
            string[] shopping = Console.ReadLine().Split();

            while (shopping[0] != "END")
            {
                Person person = GetPersonByName(shopping[0]);
                Product product = GetProductByName(shopping[1]);
                Buy(person, product);
                shopping = Console.ReadLine().Split();
            }
        }

        private static void ReadProducts()
        {
            string[] secondLine = Console.ReadLine().Split(";");
            for (int i = 0; i < secondLine.Length; i++)
            {
                string name = secondLine[i].Split("=")[0];
                double price = double.Parse(secondLine[i].Split("=")[1]);

                try
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void ReadPeople()
        {
            string[] firstLine = Console.ReadLine().Split(";");

            for (int i = 0; i < firstLine.Length; i++)
            {
                string name = firstLine[i].Split("=")[0];
                double money = double.Parse(firstLine[i].Split("=")[1]);

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void Buy(Person person, Product product)
        {
            bool result = person.BuyProduct(product);

            if (result)
            {
                Console.WriteLine($"{person.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{person.Name} can't afford {product.Name}");
            }
        }

        static Person GetPersonByName(string name)
        {
            return people.Where(p => p.Name.Equals(name)).FirstOrDefault();
        }

        static Product GetProductByName(string name)
        {
            return products.Where(p => p.Name.Equals(name)).FirstOrDefault();
        }
    }
}
