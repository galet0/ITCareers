using System;

namespace _01_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("p1");
            Person person2 = new Person("p2");
            Person person3 = new Person("p3");
            Person person4 = new Person("p4");

            Console.WriteLine(Person.Counter);
        }
    }

    class Person
    {
        private string name;
        private static int counter;
        public Person(string name)
        {
            this.name = name;
            counter++;
        }

        public static int Counter { get => Person.counter; }
    }
}
