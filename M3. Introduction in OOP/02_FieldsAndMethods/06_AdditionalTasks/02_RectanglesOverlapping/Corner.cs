using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RectanglesOverlapping
{
    class Corner
    {
        private double x;
        private double y;

        public Corner(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X
        {
            get { return x; }
            private set { x = value; }
        }
        public double Y
        {
            get { return y; }
            private set { y = value; }
        }
    }
}
