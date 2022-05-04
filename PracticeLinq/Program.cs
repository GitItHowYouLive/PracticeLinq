using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "Beat Saber", "Superhot", "Pistol Whip", "Moss", "Walkabout Mini-Golf", "Thumper", "Tetris Effect", "I Expect You To Die", "Population One", "The Walking Dead: Saints and Sinners", "Gorn", "Robo Recall", "Resist", "Rec Room", "Keep Talking and Nobody Explodes", "The Climb", "Shooty Fruity"};
            games = games.OrderBy(x => x.Length).ToList();
            foreach(var game in games)
            {
                Console.WriteLine(game);
            }
        }
    }
}
