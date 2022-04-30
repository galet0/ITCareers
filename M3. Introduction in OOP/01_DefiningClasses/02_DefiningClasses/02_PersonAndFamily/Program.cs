using System;

namespace _02_PersonAndFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], int.Parse(input[1]));
                family.AddMember(person);
            }

            Console.WriteLine(family);
            Console.WriteLine(family.GetOlderThan(30));
        }
    }
}
