using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RectanglesOverlapping
{
    class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private Corner corner;
        public Rectangle(string id, double width, double height, Corner corner)
        {
            Id = id;
            Width = width;
            Height = height;
            Corner = corner;
        }
        public string Id
        {
            get { return id; }
            private set { id = value; }
        }
        public double Width
        {
            get { return width; }
            private set { width = value; }
        }
        public double Height
        {
            get { return height; }
            private set { height = value; }
        }
        public Corner Corner
        {
            get { return corner; }
            private set { corner = value; }
        }

        public bool Overlap(Rectangle rectangle)
        {
           return rectangle.Corner.X <= this.Width && rectangle.Corner.Y <= this.Height;
        }
    }
}
