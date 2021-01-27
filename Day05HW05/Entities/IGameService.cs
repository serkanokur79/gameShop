using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Entities
{
    interface IGameService
    {
        void Add(Game game);
        void Remove(Game game);
        void Update(int Id, Game game);
        void List();
    }
}
