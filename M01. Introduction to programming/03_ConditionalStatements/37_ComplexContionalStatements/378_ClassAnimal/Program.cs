using System;

namespace _378_ClassAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            if (animal.Equals("dog"))
            {
                Console.WriteLine("mammal");
            }
            else if(animal.Equals("crocodile") || animal.Equals("tortoise") || animal.Equals("snake"))
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
