using System;
using System.Collections.Generic;

namespace _01_ADT
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice diceD6 = new Dice();//обект/инстанция
            Dice diceD8 = new Dice();//обект/инстанция

            diceD6.type = "six sides";
            diceD6.sides = 6;

            int number = diceD6.Roll();
            Console.WriteLine(number);

            diceD8.type = "eight sides";
            diceD8.sides = 8;

            int number2 = diceD8.Roll();
            Console.WriteLine(number2);

        }
    }
}
