using System;

namespace _363_SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int player3 = int.Parse(Console.ReadLine());

            int sum = player1 + player2 + player3;
            int minutes = sum / 60;
            int seconds = sum % 60;

            //Console.WriteLine(sum);
            //Console.WriteLine(minutes);
            //Console.WriteLine(seconds);

            Console.WriteLine(seconds < 10 ? $"{minutes}:0{seconds}" : $"{minutes}:{seconds}");

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
