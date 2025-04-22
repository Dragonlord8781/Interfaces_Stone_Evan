using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Stone_Evan
{
    class Movie : IGenre
    {
        //sets strings
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        //connects strings to parameters
        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        //writes line when PlayMovie called
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, please enjoy! And SSsssHHHhhhh! Thank you");
        }

        //writes line when Describe called
        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}!";
        }
    }
}
