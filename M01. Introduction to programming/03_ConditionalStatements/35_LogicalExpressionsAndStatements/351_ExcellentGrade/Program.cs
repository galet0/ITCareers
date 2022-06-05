using System;

namespace _351_ExcellentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)//true
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
