using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Team
{
    class Person
    {
        private string name;
        private double money;
        private List<Product> cart;
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.cart = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            private set { 
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be empty!");
                }
                name = value; }
        }
        public double Money
        {
            get { return money; }
            private set {
                if(value < 0)
                {
                    throw new ArgumentException("Money can not be negative!");
                }
                money = value; }
        }

        public bool BuyProduct(Product product)
        {
            if(this.Money >= product.Price)
            {
                this.Money -= product.Price;
                this.cart.Add(product);
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.cart.Any())
                sb.Append($"{this.Name} - {string.Join(", ", this.cart)}");
            else
            {
                sb.Append($"{this.Name} - Nothing bought");
            }
            return sb.ToString();
        }
    }
}
