using System;

namespace _00_This
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("dasda");
            Console.WriteLine(person.Name);

            Creature creature = new Creature("dasd", 45);

            Creature creature1 = new Creature("cvcvc", 78);

            creature = creature.ChangeAreal("new Areal");

            Console.WriteLine(creature.Areal);
            
        }
    }
}
