using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    internal class Flower
    {
        private string type;
        private string color;
        private double price;

        public Flower(string type, string color, double price)
        {
            Type = type;
            Color = color;
            Price = price;
        }

        public string Type
        {
            get { return type; }
            private set { type = value; }
        }

        public string Color
        {
            get { return color; }
            private set { color = value; }
        }


        public double Price
        {
            get { return price; }
            private set
            {
                if (value > 100)
                {
                    throw new ArgumentException("Invalid flower price!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            return $"Flower {type} with color {color} costs {price:f2}";
        }
    }
}
