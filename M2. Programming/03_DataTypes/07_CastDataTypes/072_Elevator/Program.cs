using System;

namespace _072_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = people / capacity;
            bool isGreater = people % capacity > 0;
            if (isGreater)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
