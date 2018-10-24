using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.MovieList {

    public enum MovieCategory { Animated, Action, Comedy, Drama, MartialArts, Horror, SciFi, Thriller }

    class Movie {
        public static List<string> movieCategories = new List<string>() { "Animated", "Action", "Comedy", "Drama", "Martial Arts", "Horror", "Sci-Fi" };

        public string           Title { get; set; }
        public string           Category { get; set; }
        public short            Year { get; set; }                  // %@#$*&! remakes... >.<
        public MovieCategory    MovieCategory { get; set; }

        public Movie() {
        }

        public Movie(string movieTitle, string movieCategory) {
            Title = movieTitle;
            Category = movieCategory;
        }

        public override string ToString() {
            //Let's use this method to fix the category enum, at least while printing 
            return $"{ Title } : { Category }";
        }

        public static void DisplayMovieCategories([Optional]bool menuMode) {
            for (int i = 0; i < movieCategories.Count; i++) {
                Console.WriteLine((menuMode ? $"{i + 1}.) " : "") + movieCategories[i]);
            }
        }

        public static void GetMoviesInCategory(IList<object> masterList, string category) {

            ArrayList searchResults = new ArrayList();

            if (movieCategories.Contains(category)) {
                foreach (object c in masterList) {
                    if ((c is Movie) && (c as Movie).Category == category) {
                        searchResults.Add((c as Movie).Title);
                        //Console.WriteLine(c);
                    }
                }
            }
            searchResults.Sort();

            Console.WriteLine("\nSearch Results".PadLeft(8));
            Console.WriteLine("******************************");
            foreach (object c in searchResults) {
                Console.WriteLine(c);
            }
            Console.WriteLine("******************************\n");
        }
    }
}
