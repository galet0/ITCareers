using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Store
{
    class Product
    {
        private string name;
        private string barcode;
        private double price;
        private double quantity;

        public Product(string barcode, string name, double price, double quantity)
        {
            Name = name;
            Barcode = barcode;
            Price = price;
            Quantity = quantity;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string Barcode
        {
            get { return barcode; }
            private set { barcode = value; }
        }
        public double Price
        {
            get { return price; }
            private set { price = value; }
        }
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public override string ToString()
        {
            return $"{Barcode}: {Name} Price: {Price:f2} Quantity: {Quantity:f2}";
        }
    }
}
