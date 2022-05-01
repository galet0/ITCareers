using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DefiningClassPerson
{
    class BankAccount
    {
        private int id;

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        private double balance;
        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }
        public BankAccount(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }
    }
}
