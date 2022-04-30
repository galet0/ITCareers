using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PersonsMoney
{
    class BankAccount
    {
        //fields
        private int id;
        private double balance;

        //constructor
        public BankAccount(int id) : this(id, 0) { }
        public BankAccount(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }

        //properties
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive number!");
            }
            else
            {
                //200 + 100
                Balance += amount;
                Console.WriteLine("Successfull deposit!");
            }
        }

        public void Withdraw(double amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be positive number!");
            }
            else if(amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Successfull withdraw!");
            }
        }

        public override string ToString()
        {
            return $"Account ID:{this.Id}, balance {this.Balance:f2}";
        }
    }
}
