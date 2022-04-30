using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DefinePerson
{
    class Person
    {
        public string name;
        public int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello! My name is {name}.I am {age} years old!");
        }
    }
}
