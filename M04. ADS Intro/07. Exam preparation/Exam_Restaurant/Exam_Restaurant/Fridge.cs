using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Restaurant
{
    class Fridge
    {
        private Product head;
        private Product tail;
        private int count;

        public Fridge() { }

        public int Count
        {
            get { return this.count; }
        }

        public void AddProduct(string productName)
        {
            Product newProduct = null;

            if(this.Count == 0)
            {
                newProduct = new Product(productName);
                this.head = this.tail = newProduct;
            }
            else
            {
                newProduct = new Product(productName, this.tail);
                this.tail = newProduct;
            }
            this.count++;
        }

        public string[] CookMeal(int start, int end)
        {
            string[] arr = new string[end - start + 1];

            string[] products = ProvideInformationAboutAllProducts();

            for (int i = start; i < end && i < products.Length; i++)
            {
                arr[i] = products[i];
            }
            arr = arr.Where(c => c != null).ToArray();

            return arr;
        }

        public string RemoveProductByIndex(int index)
        {
            Product previous = null;
            Product current = this.head;
            int currentIndex = 0;
            string removed = null;

            while(current != null)
            {
                removed = current.Name;
                if(currentIndex == index)
                {
                    if (previous == null)
                    {
                        this.head = this.head.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            this.tail = previous;
                        }
                    }

                    this.count--;
                    return removed;
                }

                currentIndex++;
                previous = current;
                current = current.Next;
            }

            return removed;
        }

        public string RemoveProductByName(string name)
        {
            Product current = this.head;
            string result = null;
            int index = 0;

            while(current != null)
            {
                if(current.Name == name)
                {
                    result = this.RemoveProductByIndex(index);
                }

                index++;
                current = current.Next;
            }

            return result;
        }

        public bool CheckProductIsInStock(string name)
        {
            Product current = this.head;

            while (current != null)
            {
                if(current.Name == name)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            string[] products = new string[this.Count];
            Product current = this.head;
            int index = 0;

            while (current != null)
            {
                products[index] = current.Name;

                current = current.Next;
                index++;
            }

            return products;
        }

    }
}
