using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Order
    {
        private int orderNumber;
        private List<Product> products;
        private static int counter;

        public Order(int orderNumber, List<Product> products)
        {
            this.OrderNumber = orderNumber;
            this.products = products;
            Order.counter++;
        }

        public int OrderNumber
        {
            get { return orderNumber; }
            private set { orderNumber = value; }
        }

        public static int OrdersCount { get => Order.counter; }
        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public double GetOrderTotalPrice()
        {
            return this.products.Sum(p => p.Price);
        }

        public double GetDiscountedProductsTotalPrice()
        {
            return this.products.Where(p => p.IsOnPromotion == true).Sum(p => p.Price);
        }

        public double GetDiscountedProductsCount()
        {
            return this.products.Where(p =>p.IsOnPromotion==true).Count();         
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Order #{OrderNumber} has the following products:");
            foreach (var product in products)
            {
                sb.AppendLine();
                sb.Append($"### {product}");
            }
            return sb.ToString();
        }
    }
}
