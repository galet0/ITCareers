using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SortPeopleByNameAndAge
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;
        public Person(string firstName, string lastName, int age, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name can not be less than 3 symbols!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name can not be less than 3 symbols!");
                }
                lastName = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age must be greather than 0!");
                }
                age = value;
            }
        }

        public double Salary { 
            get => this.salary; 
            private set
            {
                if(value < 460)
                {
                    throw new ArgumentOutOfRangeException("salary", "Salary must be greather than 460!");
                }
                this.salary = value;
            }
        }

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
