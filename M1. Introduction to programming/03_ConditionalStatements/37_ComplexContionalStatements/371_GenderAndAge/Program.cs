using System;

namespace _371_GenderAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if(age < 16)
            {
                if(gender == 'm')
                {
                    Console.WriteLine("Master");
                }
                else if(gender == 'f')
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if(gender == 'm')
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
