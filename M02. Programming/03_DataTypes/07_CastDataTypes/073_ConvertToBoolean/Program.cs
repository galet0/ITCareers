using System;

namespace _073_ConvertToBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            //bool isTrue = Convert.ToBoolean(input);
            bool isTrue = input.Equals("true");
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
