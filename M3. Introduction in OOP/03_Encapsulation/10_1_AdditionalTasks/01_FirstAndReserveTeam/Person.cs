using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FirstAndReserveTeam
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;
        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            LastName = lastName;
            Age = age;
            this.salary = salary;
        }

        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public double Salary { get => this.salary; }

        public void IncreaseSalary(double persent)
        {
            if (this.Age < 30)
            {
                this.salary += this.salary * persent / 200;
            }
            else
            {
                this.salary += this.salary * persent / 100;
            }
        }
        private string FullName { get => $"{this.FirstName} {this.LastName}"; }
        public override string ToString()
        {
            return $"{this.FullName} is a {this.Age} years old. Salary = {this.Salary}";
        }
    }
}
