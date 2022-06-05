using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PersonsMoney
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> myAccounts;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            myAccounts = new List<BankAccount>();
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello! My name is {name}.I am {age} years old!");
        }

        public void AddAccount(BankAccount account)
        {
            myAccounts.Add(account);
        }

        public double GetBalance()
        {
            return myAccounts.Sum(acc => acc.Balance);
        }
    }
}
