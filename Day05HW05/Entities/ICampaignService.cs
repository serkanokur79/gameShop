using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Entities
{
    interface ICampaignService
    {
        void Add(ICampaign campaign);
        void Remove(ICampaign campaign);
        void List();
        void ApplyDiscount(Game game, ICampaign campaign);
        void DisplayDiscount(ICampaign campaign);
    }
}
