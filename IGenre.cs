using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Stone_Evan
{
    interface IGenre
    {
        // sets strins Esrb, Genre,Title, and Describe in interface
        public string Esrb { get; set; }
        
        public string Genre { get; set;}

        public string Title { get; set; }

        public string Describe();

    }
}
