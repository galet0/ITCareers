using System;

namespace _02_AnimalsFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                try
                {
                    Chicken chicken = new Chicken(name, age);
                    Console.WriteLine(chicken);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
