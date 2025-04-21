﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Stone_Evan
{
    class Movie : IGenre
    {
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, please enjoy! And SSsssHHHhhhh! Thank you");
        }

        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}!";
        }
    }
}
