using Day05HW05.Concrete;
using Day05HW05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Manager
{
    class PlayerManager : IPlayerService
    {
        List<Player> players = new List<Player>();
        private UserValidationManager _userValidationManager;

        public PlayerManager(UserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }

        public void Add(Player player)
        {
            if (_userValidationManager.Validate(player))
            {
            players.Add(player);
                Console.WriteLine("Player added to db: " + player.FirstName);
            }
            else
            {
                Console.WriteLine("Operation failed: {0} {1} has Fake Id", player.FirstName, player.Surname);
            }
        }

        public void CheckIfRealPerson()
        {
            throw new NotImplementedException();
        }

        public void List()
        {
            Console.WriteLine("==============All players================");
            Console.WriteLine("First Name \t Surname \t\t" );
            foreach (var player in players)
            {
                Console.WriteLine("{0} \t\t {1} \t\t",player.FirstName, player.Surname );
            }
        }

        public void Remove(Player player)
        {
            players.Remove(player);
        }
    }
}
