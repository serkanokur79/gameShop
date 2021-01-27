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

        public void Add(Player player)
        {
            players.Add(player); 
        }

        public void CheckIfRealPerson()
        {
            throw new NotImplementedException();
        }

        public void Remove(Player player)
        {
            players.Remove(player);
        }
    }
}
