using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Entities
{
    interface IShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public double ReviewScore { get; set; }
        public double Price { get; set; }
    }
}
