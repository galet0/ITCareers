using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                Car car = new Car(info[0], double.Parse(info[1]), double.Parse(info[2]));
                cars.Add(car);
            }

            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] command = line.Split();

                Car carToDrive = cars.Where(car => car.Model.Equals(command[1])).FirstOrDefault();
                carToDrive.Drive(double.Parse(command[2]));
                
                line = Console.ReadLine();
            }

            foreach (var c in cars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
