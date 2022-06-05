using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RawData
{
    class Cargo
    {
        private string cargoType;
        private int weight;

        public Cargo(int weight, string type)
        {
            Weight = weight;
            CargoType = type;
        }

        public string CargoType
        {
            get { return cargoType; }
            private set { cargoType = value; }
        }
        public int Weight
        {
            get { return weight; }
            private set { weight = value; }
        }
    }
}
