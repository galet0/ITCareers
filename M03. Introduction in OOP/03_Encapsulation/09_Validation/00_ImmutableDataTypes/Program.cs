using System;

namespace _00_ImmutableDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //immutable
            string myString = "old String";
            Console.WriteLine(myString);
            string newString = myString.Replace("old", "new");
            Console.WriteLine(myString);
            Console.WriteLine(newString);

            //mutable
            Point myPoint = new Point(0.0, 0.0);
            Console.WriteLine(myPoint);

            myPoint.SetLocation(1.0, 0.0);
            Console.WriteLine(myPoint);

        }
    }

    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetLocation(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x: {this.x}; y: {this.y}";
        }
    }
}
