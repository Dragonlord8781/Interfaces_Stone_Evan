using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Stone_Evan
{
    class Game : IGenre
    {

        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void Playgame()
        {
            Console.WriteLine($"{Title} is booting up! Have fun!");
        }

        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }


    }
}
