using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OldestFamilyMember
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
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

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
