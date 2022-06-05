using System;

namespace _05_Banker
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(1, 100);
            BankAccount acc2 = new BankAccount(2, 200);
            BankAccount acc3 = new BankAccount(3, 300);
            BankAccount acc4 = new BankAccount(4, 400);
            try
            {
                Console.WriteLine(Bank.Add(acc1));
                Console.WriteLine(Bank.Add(acc2));
                Console.WriteLine(Bank.Add(acc3));
                Console.WriteLine(Bank.Add(acc4));
                Console.WriteLine(Bank.Deposit(acc1.Id, 200));
                Console.WriteLine(Bank.Withdraw(acc2.Id, 100));
                Console.WriteLine(Bank.GetAccountBalance(acc1.Id));
                Console.WriteLine(Bank.GetAccountBalance(acc2.Id));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
