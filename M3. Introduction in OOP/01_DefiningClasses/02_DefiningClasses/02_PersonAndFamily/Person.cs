using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PersonAndFamily
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }
    }
}
