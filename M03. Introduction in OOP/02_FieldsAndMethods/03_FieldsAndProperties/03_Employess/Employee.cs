using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Employess
{
    class Employee
    {
        //Pesho 120.00 Dev Development pesho@abv.bg 28
        private string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        private double salary;
        public double Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        private string position;
        public string Position
        {
            get { return position; }
            private set { position = value; }
        }

        private string department;
        public string Department
        {
            get { return department; }
            private set { department = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            private set { email = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public Employee(string name, double salary, string position, string department, string email, int age)
            : this(name, salary, position, department)
        {
            Email = email;
            Age = age;
        }

        public Employee(string name, double salary, string position, string department, int age) 
            : this(name, salary, position, department)
        {
            Age = age;
        }
        public Employee(string name, double salary, string position, string department, string email)
            : this(name, salary, position, department)
        {
            Email = email;
        }
        public Employee(string name, double salary, string position, string department)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = "n/a";
            Age = -1;
        }

        public override string ToString()
        {
            return $"{Name} {Salary:f2} {Email} {Age}";
        }
    }
}
