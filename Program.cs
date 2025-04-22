using Interfaces_Stone_Evan;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // writes program #
            Console.WriteLine("Program 15");

            //favGame
            Game favGame = new Game("T", "Action RPG", "Monster Hunter:Wild");// sets favGame as new Game and Esrb=T, Genre=Action RPG, and Title = Monster Hunter:Wild
            Console.WriteLine(favGame.Describe());//writes line using Describe 
            favGame.Playgame(); // calls Playgame

            //favMovie
            Movie favMovie = new Movie("PG", "Adventure", "How to Train Your Dragon");// sets favMovie as new Game and Esrb = PG, Genre = Adventure, and Title = How to Train Your Dragon
            Console.WriteLine(favMovie.Describe());// writes line using Describe
            favMovie.PlayMovie();// calls Playmovie
        }
    }
}