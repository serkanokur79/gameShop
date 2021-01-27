using Day05HW05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Manager
{
    class GameManager : IGameService
    {
        List<Game> gameList = new List<Game>();

        public void Add(Game game)
          {
            gameList.Add(game);
            Console.WriteLine("Game Added to db: {0} ({1})", game.Name, game.ReleaseYear);
        }

        public void List()
        {
            Console.WriteLine("\n======= All Games ========");
            Console.WriteLine("Name \t \t Release Year \t Review Score \t Price($)");
            foreach(var game in gameList)
            {
                Console.WriteLine("{0} \t\t {1} \t\t {2} \t {3}", game.Name, game.ReleaseYear, game.ReviewScore, game.Price);
            }
            Console.WriteLine("\n");
        }

        public void Remove(Game game)
        {
            gameList.Remove(game);
            Console.WriteLine("Game Removed from db: {0} ({1})", game.Name, game.ReleaseYear);
        }

        public void Update(int Id, Game game)
        {
            foreach(var _game in gameList) {

               _game.Name =  _game.Id == Id ? game.Name  : _game.Name;
                _game.ReleaseYear = _game.Id == Id ? game.ReleaseYear : _game.ReleaseYear;
                _game.ReviewScore = _game.Id == Id ? game.ReviewScore : _game.ReviewScore;
                _game.Price = _game.Id == Id ? game.Price : _game.Price;


            }
            Console.WriteLine("Game {0} is updated as:" , Id);
            Console.WriteLine("Name \t \t Release Year \t Review Score \t Price($)");
            Console.WriteLine("{0} \t\t {1} \t\t {2} \t {3}", game.Name, game.ReleaseYear, game.ReviewScore, game.Price);

        }


    }
}
