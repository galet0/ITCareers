using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11072021
{
    public class VideoLibrary
    {
        private string name;
        private List<Movie> movies;

        public VideoLibrary(string name)
        {
            this.Name = name;
            this.movies = new List<Movie>();
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public IReadOnlyList<Movie> Movies
        {
            get { return this.movies; }   
        }

        public void AddMovie(string title, double rating)
        {
            Movie movie = new Movie(title, rating);
            this.movies.Add(movie);
        }

        public double AverageRating()
        {
            return this.movies.Average(m => m.Rating);                          
        }

        //public List<string> RemoveMoviesByRating(double rating)
        //{
        //    //TODO: Добавете вашия код тук …                            
        //}

        public List<Movie> SortByTitle()
        {
            this.movies = this.movies.OrderBy(m => m.Title).ToList();
            return this.movies;
        }

        public List<Movie> SortByRating()
        {
            this.movies = this.movies.OrderByDescending(m => m.Rating).ToList();
            return this.movies;
        }

        public string[] ProvideInformationAboutAllMovies()
        {
            string[] movies = new string[this.movies.Count];
            for (int i = 0; i < this.movies.Count; i++)
            {
                movies[i] = this.movies[i].ToString();
            }

            return movies;
        }

        public bool CheckMovieIsInVideoLibrary(string title)
        {
            return this.movies.Where(m => m.Title.Equals(title)).FirstOrDefault() != null;
        }

        public List<string> GetMoviesByRating(double rating)
        {
            List<string> bestMovies = this.movies
                .Where(m => m.Rating > rating)
                .Select(m => m.Title)
                .ToList();

            return bestMovies;
        }
    }
}
