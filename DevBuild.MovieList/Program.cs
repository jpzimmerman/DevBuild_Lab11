using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBuild.Utilities;

namespace DevBuild.MovieList {
    class Program {

        public static ArrayList ourMovies = new ArrayList();

        static void Main(string[] args) {
            ourMovies.Add(new Movie("Titan AE", "Animated"));
            ourMovies.Add(new Movie("An American Tail", "Animated"));
            ourMovies.Add(new Movie("Robin Hood: Men in Tights", "Comedy"));
            ourMovies.Add(new Movie("Get Out", "Horror"));
            ourMovies.Add(new Movie("Fist of Legend", "Martial Arts"));
            ourMovies.Add(new Movie("Tucker and Dale vs. Evil", "Horror"));
            ourMovies.Add(new Movie("A Bug's Life", "Animated"));
            ourMovies.Add(new Movie("Interstellar", "Sci-Fi"));
            ourMovies.Add(new Movie("Contact", "Sci-Fi"));
            ourMovies.Add(new Movie("The Imitation Game", "Drama"));
            while (true) {
                MenuHandling.PrintMenuOptions(Movie.movieCategories.ToArray(), menuMode: true);
                uint userSelection = MenuHandling.SelectMenuOption(Movie.movieCategories.Count);
                Movie.GetMoviesInCategory(ourMovies.ToArray(), Movie.movieCategories[(int)userSelection -1]);

                YesNoAnswer yesNoAnswer = UserInput.GetYesOrNoAnswer("Do you want to search again? (y/n or yes/no) ");
                switch (yesNoAnswer) {
                    case YesNoAnswer.Yes: continue;
                    case YesNoAnswer.No: return;
                    default: continue;
                }

            }
        }
    }
}
