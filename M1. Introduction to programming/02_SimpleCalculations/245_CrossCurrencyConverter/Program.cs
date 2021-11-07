using System;

namespace _245_CrossCurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = 1.79549;
            double EUR = 1.95583;
            double GBP = 2.53405;

            double amount = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            double result = 0;
            if (inputCurrency.Equals("USD"))
            {
                result = amount * USD;
            }
            else if (inputCurrency.Equals("EUR"))
            {
                result = amount * EUR;
            }
            else if (inputCurrency.Equals("GBP"))
            {
                result = amount * GBP;
            }
            else if (inputCurrency.Equals("BGN"))
            {
                result = amount;
            }

            if (outputCurrency.Equals("USD"))
            {
                result = result / USD;
            }
            else if (outputCurrency.Equals("EUR"))
            {
                result = result / EUR;
            }
            else if (outputCurrency.Equals("GBP"))
            {
                result = result / GBP;
            }

            Console.WriteLine($"{result:f2} {outputCurrency}");
        }
    }
}
