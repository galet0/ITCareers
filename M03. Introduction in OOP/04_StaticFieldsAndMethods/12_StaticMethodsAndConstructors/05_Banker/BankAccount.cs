using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Banker
{
    class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }

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

        public string Deposit(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Deposit amount cannot be less or equal to 0;");
            }

            this.Balance += amount;

            return "Successfull deposit!";
        }

        public string Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Withdraw amount cannot be less or equal to 0;");
            }
            if(this.Balance < amount)
            {
                throw new ArgumentException("Insifissient balance!");
            }

            this.Balance -= amount;

            return "Successfull withdraw!";
        }
    }
}
