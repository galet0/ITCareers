using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Travel
{
    class Car
    {
        private string model;
        private double fuelQuantity;
        private double fuelConsumption;
        private double traveledDistance;
        public Car(string model, double fuelQuantity, double fuelConsumption)
        {
            Model = model;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public string Model
        {
            get { return model; }
            private set { model = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            private set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            private set { fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * this.FuelConsumption;

            if(fuelNeeded <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;
                this.traveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive!");
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelQuantity:f2} {traveledDistance}";
        }
    }
}
