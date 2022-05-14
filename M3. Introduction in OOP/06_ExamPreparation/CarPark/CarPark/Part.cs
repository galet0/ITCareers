using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class Part
    {
        private string name;
        private double price;
        private const double Default_Price = 25;
        public Part(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Part(string name) : this(name, Default_Price) { }

        public string Name
        {
            get { return name; }
            private set { 
                if(value.Length < 5)
                {
                    throw new ArgumentException("Invalid part name!");
                }
                name = value; }
        }
        public double Price
        {
            get { return price; }
            private set { 
                if(value < 0)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                price = value; }
        }

        public override string ToString()
        {
            return $"-> {this.Name} - {this.Price:f2}";
        }
    }
}
