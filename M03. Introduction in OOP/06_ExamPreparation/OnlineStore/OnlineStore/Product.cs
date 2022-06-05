using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Product
    {
        private string name;
        private double price;
        private bool isOnPromotion;

        public Product(string name, double price, bool isOnPromotion)
        {
            this.Name = name;
            this.isOnPromotion = isOnPromotion;
            this.Price = price;            
        }
        public Product(string name, double price) : this(name, price, false) { }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid product name!");
                }
                name = value;
            }
        }
        public double Price
        {
            get { return price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                if (this.IsOnPromotion)
                {
                    price = value - value * 0.2;
                }
                else
                {
                    price = value;
                }
            }
        }
        public bool IsOnPromotion
        {
            get { return isOnPromotion; }
        }

        public override string ToString()
        {
            if (IsOnPromotion)
            {
                return $"Product -> {Name} with price {Price:f2}. On promotion: YES";
            }

            return $"Product -> {Name} with price {Price:f2}. On promotion: NO";
        }
    }
}
