using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DefiningClassPerson
{
    class Person
    {
        private List<BankAccount> accounts;

        public Person()
        {
            Name = "No name";
            Age = -1;
        }

        public Person(int age) : this("No name", age)
        {

        }
        public Person(string name, int age) : this(name, age, new List<BankAccount>())
        {
        }
        public Person(string name, int age, List<BankAccount> accounts)
        {
            Name = name;
            Age = age;
            this.accounts = accounts;
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

        public double GetBalance()
        {
            return accounts.Sum(a => a.Balance);
        }
    }
}
