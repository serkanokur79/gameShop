using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Entities
{
    class Campaign : ICampaign
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        public int DiscountRate { get ; set ; }
    }
}
