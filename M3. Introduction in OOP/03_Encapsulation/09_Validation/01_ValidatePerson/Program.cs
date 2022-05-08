using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_SortPeopleByNameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            try
            {
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), double.Parse(cmdArgs[3]));
                    persons.Add(person);
                }

                foreach (var item in persons)
                {
                    item.IncreaseSalary(30);
                }

                persons.OrderBy(p => p.FirstName)
                       .ThenBy(p => p.Age)
                       .ToList()
                       .ForEach(p => Console.WriteLine(p.ToString()));

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
