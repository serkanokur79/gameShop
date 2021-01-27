using Day05HW05.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Entities
{
    interface IPlayerService
    {
        void CheckIfRealPerson();
        void Add(Player player);
        void Remove(Player player);
    }
}
