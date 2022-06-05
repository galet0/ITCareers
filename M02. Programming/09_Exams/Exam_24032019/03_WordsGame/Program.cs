using System;
using System.Linq;

namespace _03_WordsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            
            int maxPoints = 0;
            string winner = null;

            while(word != "END OF GAME")
            {
                int points = 0;
                points += word.Sum(ch => ch);
                if(word[0].ToString() == word[0].ToString().ToUpper())
                {
                    points += 15;
                }
                if (word.EndsWith('t'))
                {
                    points += 20;
                }
                if(word.Length >= 10)
                {
                    points += 30;
                }

                if(points > maxPoints)
                {
                    maxPoints = points;
                    winner = word;
                }

                word = Console.ReadLine();
            }

            Console.WriteLine($"Winner is word: {winner}");
            Console.WriteLine($"Points: {maxPoints}");
        }
    }
}
