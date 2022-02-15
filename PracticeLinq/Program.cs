using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gameList = new List<string>() { "PGR2", "iRacing", "ACC", "Halo Infinite", "Portal 2", "Rocket League" };

            var orderedGames = gameList.OrderBy(game => game);

            Console.WriteLine("Games listed A-Z");
            foreach (var game in orderedGames)
            {
                Console.WriteLine($"  {game}");
            }

            Console.WriteLine("");
            Console.WriteLine("Games that contain the number 2");
            var otherFilter = gameList.Where(game => game.Contains("2"));

            foreach (var game in otherFilter)
            {
                Console.WriteLine($"  {game}");
            }
            
            Console.WriteLine("");
            Console.WriteLine("Games that have a space in them");
            var filteredGames = gameList.Where(game => game.Contains(" "));

            foreach (var game in filteredGames)
            {
                Console.WriteLine($"  {game}");
            }


            
        }
    }
}
