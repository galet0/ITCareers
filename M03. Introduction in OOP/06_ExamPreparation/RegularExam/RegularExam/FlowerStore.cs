
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    internal class FlowerStore
    {

        private string name;
        private List<Flower> flowers;

        public FlowerStore(string name)
        {
            Name = name;
            this.flowers = new List<Flower>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid flower store name!");
                }
                name = value;













            }



        }


        public void AddFlower(Flower flower)
        {
            this.flowers.Add(flower);

        }

        public bool SellFlower(Flower flower)
        {
            Flower flowerToSell = this.flowers.Where(f => f.Type == flower.Type && f.Color == flower.Color && f.Price
           == flower.Price).FirstOrDefault();
            return this.flowers.Remove(flowerToSell);
        }

        public double CalculateTotalPrice()
        {
            return this.flowers.Sum(f => f.Price);
        }

        public Flower GetFlowerWithHighestPrice()
        {
            return this.flowers.OrderByDescending(f => f.Price).FirstOrDefault();
        }

        public Flower GetFlowerWithLowestPrice()
        {
            return this.flowers.OrderBy(f => f.Price).FirstOrDefault();
        }

        public void RenameFlowerStore(string newName)
        {
            this.Name = newName;
        }

        public void SellAllFlowers()
        {
            this.flowers.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Flower store {Name} has");
            if (flowers.Count > 0)
            {
                sb.Append($" {flowers.Count} flower/s:");
                foreach (var flower in flowers)
                {                    
                    sb.AppendLine();
                    sb.Append(flower.ToString());
                }

            }
            else
            {
                sb.Append(" no available flowers");
            }
            return sb.ToString();
        }
    }
}
