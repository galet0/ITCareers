using System;

namespace _03_SplitStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
            string[] beers = listOfBeers.Split(new char[] { ',', ' ', '.'},  StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Available beers are:");
            foreach (var item in beers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
