using Day05HW05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Manager
{
    class CampaignManager : ICampaignService


    {
        List<ICampaign> campaigns = new List<ICampaign>();

        public void Add(ICampaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("Campaign added to db: {0} ({1}%)", campaign.Name, campaign.DiscountRate);
        }

        public void ApplyDiscount(Game game, ICampaign campaign)
        {
            var _discount = campaign.DiscountRate;
            var _gamePrice = game.Price;
            var newGamePrice = _gamePrice * (100 - _discount) / 100;

            game.Price = newGamePrice;
            Console.WriteLine("Price of {0} is now ${1} with {2} campaign", game.Name, game.Price, campaign.Name);
        }

        public void DisplayDiscount(ICampaign campaign)
        {

            Console.WriteLine("Discount rate of {0} campaign is {1}% ", campaign.Name, campaign.DiscountRate);
        }

        public void List()
        {
            Console.WriteLine("\n=============== All Campaigns ===========");
            Console.WriteLine("Name \t\t Discount Rate(%) ");
            foreach (var campaign in campaigns)
            {

            Console.WriteLine("{0} \t\t {1}", campaign.Name, campaign.DiscountRate);
            }
            Console.WriteLine("\n");
        }

        public void Remove(ICampaign campaign)
        {
            campaigns.Remove(campaign);
        }
    }
}
