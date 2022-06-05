using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_This
{
    class Creature
    {
        private string name;
        private int age;
        private string areal;
        private DateTime birthDate;

        public Creature(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.ChangeAreal("n/a");
            this.birthDate = DateTime.Now;
        }

        public Creature(string name, int age, string areal) : this(name, age)
        {
            Areal = areal;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }
        public string Areal
        {
            get { return this.areal; }
            private set { this.areal = value; }
        }

        public Creature ChangeAreal(string areal)
        {
            this.Areal = areal;
            return this;
        }
        private void Growup()
        {
            DateTime today = DateTime.Now;
            if((today - birthDate).TotalDays == 365)
                this.Age++;
        }
    }
}
