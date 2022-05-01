using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RawData
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
        public string Model
        {
            get { return model; }
            private set { model = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            private set { engine = value; }
        }
        public Cargo Cargo
        {
            get { return cargo; }
            private set { cargo = value; }
        }
        public List<Tire> Tires
        {
            get { return tires; }
            private set { tires = value; }
        }

        public override string ToString()
        {
            return this.Model;
        }
    }
}
