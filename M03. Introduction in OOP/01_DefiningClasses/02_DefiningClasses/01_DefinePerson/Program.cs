using System;

namespace _01_DefinePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Petya";
            person.age = 12;
            person.Name = "Nina";
            person.IntroduceYourself();

            Person person1 = new Person();
            person1.name = "Sashko";
            person1.age = 5;

            person1.IntroduceYourself();
        }
    }
}
