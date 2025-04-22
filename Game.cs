using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Stone_Evan
{
    class Game : IGenre
    {
        //sets stings
        public string Esrb { get; set; }//set Esrb

        public string Genre { get; set; }// set Genre

        public string Title { get; set; }//set Title 
        
        //connects striongs to parameters
        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }
       
        //writes line when Playgame called
        public void Playgame()
        {
            Console.WriteLine($"{Title} is booting up! Have fun!");
        }

        // writes line when describe called
        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }


    }
}
