using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AnimalsFarm
{
    class Chicken
    {
        private string name;
        private int age;
        private int productPerDay;

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be empty.");
                }
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentOutOfRangeException("age", "Age should be between 0 and 15.");
                }
                age = value;
            }
        }

        public int ProductPerDay { get => this.productPerDay; }

        private int CalculateProductPerDay()
        {
            Random random = new Random();
            this.productPerDay = random.Next(1 * this.Age / 10, 10 * this.Age / 10);

            return this.productPerDay;
        }

        public override string ToString()
        {
            return $"Chicken {this.Name} (age {this.Age}) can produce {this.CalculateProductPerDay()} eggs per day.";
        }
    }
}
