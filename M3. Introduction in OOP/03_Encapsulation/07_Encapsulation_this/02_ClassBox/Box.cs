using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassBox
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        /*
            Volume = lwh
            Lateral Surface Area = 2lh + 2wh
            Surface Area = 2lw + 2lh + 2wh
         */
        public double Volume()
        {
            return this.length * this.width * this.height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double SurfaceArea()
        {
            return 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;

        }
    }
}
