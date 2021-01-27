using Day05HW05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Concrete
{
    class Player : IPerson
    {
        public string FirstName { get ; set ; }
        public string Surname { get ; set ; }
        public long TcNo { get ; set ; }
        public int BirthYear { get ; set ; }
    }
}
