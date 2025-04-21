using Interfaces_Stone_Evan;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 15");

            Game favGame = new Game("T", "Action RPG", "Monster Hunter:Wild");
            Console.WriteLine(favGame.Describe());
            favGame.Playgame();

            Movie favMovie = new Movie("PG", "Adventure", "How to Train Your Dragon");
            Console.WriteLine(favMovie.Describe());
            favMovie.PlayMovie();
        }
    }
}