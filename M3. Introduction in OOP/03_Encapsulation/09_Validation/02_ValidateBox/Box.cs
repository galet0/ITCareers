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

        public double Length
        {
            get => length;
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("length", "Length can not be less than 1!");
                length = value;
            }
        }
        public double Width
        {
            get => width;
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("width", "Width can not be less than 1!");
                width = value;
            }
        }
        public double Height
        {
            get => height; 
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("height", "Height can not be less than 1!");
                height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }



        /*
            Volume = lwh
            Lateral Surface Area = 2lh + 2wh
            Surface Area = 2lw + 2lh + 2wh
         */
        public double Volume()
        {
            return this.Length * this.Width * this.Height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double SurfaceArea()
        {
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;

        }
    }
}
