using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ADT
{
    class Dice
    {
        public int sides;
        public string type;

        public int Roll()
        {
            Random random = new Random();
            return random.Next(1, sides + 1);
        }
    }
}
