using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                //ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4
                //“<Модел> <СкоростНаДвигателя> <МощностнаДвигателя> <ТеглоНаТовара> <ТипНаТовара> <Гума1Налягане> <Гума1Възраст> <Гума2Налягане> <Гума2Възраст> <Гума3Налягане> <Гума3Възраст> <Гума4Налягане> <Гума4Възраст>
                string[] input = Console.ReadLine().Split();
                string model = input[0];

                Engine engine = CreateEngine(input.Skip(1).Take(2).ToList());
                Cargo cargo = CreateCargo(input.Skip(3).Take(2).ToList());
                List<Tire> tires = new List<Tire>();
                for (int t = 0; t < 4; t++)
                {
                    Tire tire = CreateTire(input.Skip(5).ToList());
                    tires.Add(tire);
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string cmd = Console.ReadLine();
            cars = FilterCars(cars, cmd);

            Console.WriteLine(string.Join(Environment.NewLine, cars));
            
        }

        private static List<Car> FilterCars(List<Car> cars, string cmd)
        {
            if (cmd == "fragile")
            {
                cars = cars.Where(c => c.Cargo.CargoType.Equals(cmd)
                            && c.Tires.Where(t => t.Pressure < 1).Count() > 0)
                    .ToList();
            }
            else if (cmd == "flamable")
            {
                cars = cars.Where(c => c.Cargo.CargoType.Equals(cmd)
                           && c.Engine.Power > 250)
                   .ToList();
            }

            return cars;
        }

        private static Tire CreateTire(List<string> args)
        {
            return new Tire(double.Parse(args[0]), int.Parse(args[1]));
        }

        private static Cargo CreateCargo(List<string> args)
        {
            return new Cargo(int.Parse(args[0]), args[1]);
        }

        private static Engine CreateEngine(List<string> args)
        {
            return new Engine(int.Parse(args[0]), int.Parse(args[1]));
        }
    }
}
