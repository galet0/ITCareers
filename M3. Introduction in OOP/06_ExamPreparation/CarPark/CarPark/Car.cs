using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class Car
    {

        private string manufacturer;
        private string model;
        private double loadCapacity;
        private List<Part> parts;
        private double fuel;
        private static int counter;

        public Car(string manufacturer, string model, double loadCapacity)
        {
            this.parts = new List<Part>();
            this.fuel = 100;
            Car.counter++;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.LoadCapacity = loadCapacity;
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid manufacturer name!");
                }
                manufacturer = value;
            }
        }
        public string Model
        {
            get { return model; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid model name!");
                }
                model = value;
            }
        }
        public double LoadCapacity
        {
            get { return loadCapacity; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid load capacity!");
                }
                loadCapacity = value;
            }
        }

        public double GetCarPrice() { return this.parts.Sum(p => p.Price); }

        public static double OrdersCount { get => Car.counter; }

        public void AddPart(Part part)
        {
            this.parts.Add(part);
        }

        public void AddMultipleParts(List<Part> parts)
        {
            this.parts.AddRange(parts);
        }

        public void RemovePartByName(string partName)
        {
            Part part = this.GetPartByName(partName);
            if (part != null)
            {
                this.parts.Remove(part);
            }
        }

        public bool ContainsPart(string partName)
        {
            return this.GetPartByName(partName) != null ? true : false;
        }

        public void Drive(double distance)
        {
            double fuelNeeded = this.fuel - this.LoadCapacity * 0.2 * distance;
            if(fuelNeeded < 0)
            {
                throw new ArgumentException("Drive not possible!");
            }

            this.fuel -= fuelNeeded;
        }

        public Part GetMostExpensivePart()
        {
            return this.parts.OrderByDescending(p => p.Price).FirstOrDefault();
        }

        public List<Part> GetPartsWithPriceAbove(double price)
        {
            return this.parts.Where(p => p.Price > price).ToList();
        }
        private Part GetPartByName(string partName)
        {
            return this.parts.Where(p => p.Name.Equals(partName)).FirstOrDefault();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model.ToUpper()} made by {this.Manufacturer}");
            sb.AppendLine("Available parts:");
            foreach (var part in this.parts)
            {
                sb.AppendLine(part.ToString());
            }
            sb.Append($"With total price of: {this.GetCarPrice():f2} lv.");
            return sb.ToString();
        }
    }
}
