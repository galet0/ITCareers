using _02_PersonAndFamily;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace _02_PersonsMoney
{
    class Program
    {        
        static Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
            Console.WriteLine(fields.Length);

            string line = Console.ReadLine();

            while (!line.Equals("End"))
            {
                string[] cmd = line.Split();
                int id = int.Parse(cmd[1]);
                double amount = 0;
                switch (cmd[0])
                {
                    case "Create":
                        Create(id);
                        break;
                    case "Deposit":
                        amount = double.Parse(cmd[2]);
                        Deposit(id, amount);
                        break;
                    case "Withdraw":
                        amount = double.Parse(cmd[2]);
                        Withdraw(id, amount);
                        break;
                    case "Print":
                        Print(id);
                        break;
                }
                line = Console.ReadLine();
            }
        }

        private static void Print(int id)
        {
            if (!Exist(id))
            {
                Console.WriteLine($"Account with ID = {id} does not exist");
            }
            else
            {
                Console.WriteLine(accounts[id]);
            }
        }

        private static void Withdraw(int id, double amount)
        {
            if (!Exist(id))
            {
                Console.WriteLine($"Account with ID = {id} does not exist");
            }
            else
            {
                accounts[id].Withdraw(amount);
            }
        }

        private static void Deposit(int id, double amount)
        {
            if (!Exist(id))
            {
                Console.WriteLine($"Account with ID = {id} does not exist");
            }
            else
            {
                //Deposit {Id} {Amount}
                accounts[id].Deposit(amount);
            }
        }

        private static void Create(int id)
        {
            if (!Exist(id))
            {
                BankAccount account = new BankAccount(id);
                accounts.Add(id, account);
            }
            else
            {
                Console.WriteLine($"Account with ID = {id} already exists!");
            }
        }

        public static bool Exist(int id)
        {
            return accounts.ContainsKey(id);
        }
    }
}
