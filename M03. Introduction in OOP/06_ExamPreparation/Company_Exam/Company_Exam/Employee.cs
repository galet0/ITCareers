using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Exam
{
    class Employee
    {
        private string id;
        private string firstName;
        private string lastName;
        private int age;
        private double salary;
        private const double Default_Salary = 500;
        public Employee(string id, string firstName, string lastName, int age, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public Employee(string id, string firstName, string lastName, int age) 
            : this(id, firstName, lastName, age, Default_Salary){}

        public string Id
        {
            get { return id; }
            private set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            private set { 
                if(value.Length < 3 || value.Length > 8)
                {
                    throw new ArgumentException("Invalid employee name");
                }
                firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            private set { 
                if(value < 0)
                {
                    throw new ArgumentException("Invalid employee age");
                }
                age = value; }
        }
        public double Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        public void ReceiveBonus(double amount)
        {
            this.Salary += amount;
        }

        public void Amercement(double amount)
        {
            if(amount <= this.Salary)
            {
                this.Salary -= amount;
            }
        }
        public override string ToString()
        {
            return $"Employee: {this.FirstName} {this.LastName} with id: {this.Id} and salary: {this.Salary:f2}";
        }
    }
}
