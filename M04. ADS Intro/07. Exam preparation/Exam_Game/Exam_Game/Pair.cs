using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Game
{
    class Pair
    {
        public int First { get; set; }
        public int Last { get; set; }

        public Pair(int first, int last)
        {
            this.First = first;
            this.Last = last;
        }

        public override string ToString()
        {
            //TODO: Add code
            return $"({this.First}, {this.Last})";
        }

        public int Difference()
        {
            //TODO: Add code
            return Math.Abs(this.First - this.Last);
        }

    }
}
