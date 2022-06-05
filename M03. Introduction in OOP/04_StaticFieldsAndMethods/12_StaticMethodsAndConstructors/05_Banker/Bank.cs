using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Banker
{
    static class Bank
    {
        private static List<BankAccount> accounts;

        static Bank()
        {
            accounts = new List<BankAccount>();
        }

        public static string Add(BankAccount account)
        {
            BankAccount acc = GetAccountById(account.Id);
            if(acc != null)
            {
                return $"Account with {account.Id} already exists!";
            }
            accounts.Add(account);

            return $"Account with {account.Id} successfully added!";
        }
        public static string Deposit(int id, double amount)
        {
            BankAccount account = GetAccountById(id);
            if (account == null)
            {
                return $"Account with ID: {id} does not exists!";
            }

            return account.Deposit(amount);
        }

        public static string Withdraw(int id, double amount)
        {
            BankAccount account = GetAccountById(id);
            if (account == null)
            {
                return $"Account with ID: {id} does not exists!";
            }

            return account.Withdraw(amount);
        }

        public static double GetAccountBalance(int id)
        {
            return GetAccountById(id).Balance;
        }
        private static BankAccount GetAccountById(int id)
        {
            return accounts.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
