using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11072021
{
    public class Movie
    {
        private string title;
        private double rating;

        public Movie(string title, double rating)
        {
            Title = title;
            Rating = rating;
        }

        public string Title
        {
            get { return title; }
            private set { title = value; }
        }
        public double Rating
        {
            get { return rating; }
            private set { rating = value; }
        }

        public override string ToString()
        {
            return $"Movie {this.Title} is with {this.Rating:f1} rating.";
        }
    }
}
