using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{

    class Program
    {

        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Name a movie category: Animated, Drama, Horror, or sci-fi");
                string userInput = Console.ReadLine();

                Movies m1 = new Movies("Rat Race", "Comedy");
                Movies m2 = new Movies("Black Panther", "Action");
                Movies m3 = new Movies("The Fighting Temptations", "Comedy");
                Movies m4 = new Movies("Monsters Inc'", "Animated");
                Movies m5 = new Movies("Toy Story", "Animated");
                Movies m6 = new Movies("Safe House", "Action");
                Movies m7 = new Movies("Frozen", "Animated");
                Movies m8 = new Movies("Friday the 13th", "Horror");
                Movies m9 = new Movies("Childs Play", "Horror");
                Movies m10 = new Movies("American Pie", "Comedy");


                List<Movies> movies = new List<Movies>() { m1, m2, m3, m4, m5, m6, m7, m8, m9, m10 };


                List<Movies> matchingMovies = new List<Movies>();


                foreach (Movies film in movies)
                {
                    if (film.Category == userInput)
                    {
                        matchingMovies.Add(film);
                    }
                }

                foreach (Movies film in matchingMovies)
                {
                    Console.WriteLine(film.Title);
                }
                run = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Continue? (y/n)");
            string again = Console.ReadLine().ToLower();
            bool repeat = true;

            if (again == "y")
            {
                repeat = true;
            }
            else if (again == "n")
            {
                Console.WriteLine("Goodbye!");
                repeat = false;
            }
            else
            {
                Console.WriteLine("Invalid Input! Please try again");
            }
            return repeat;
        }
    }
}
