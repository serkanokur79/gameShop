using Day05HW05.Concrete;
using Day05HW05.Entities;
using Day05HW05.Manager;
using System;

namespace Day05HW05
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game01 = new Game() { Id = 1, Name = "The Witcher 3", ReleaseYear = 2015, ReviewScore = 95, Price = 100 };
            Game game02 = new Game() { Id = 2, Name = "God Of War", ReleaseYear = 2018, ReviewScore = 95, Price = 110 };
            Game game03 = new Game() { Id = 3, Name = "The Last of Us", ReleaseYear = 2012, ReviewScore = 94, Price = 50 };
            Game game03_update = new Game() { Id = 3, Name = "The Last of Us", ReleaseYear = 2013, ReviewScore = 94, Price = 90 };


            GameManager gameManager = new GameManager();

            gameManager.Add(game01);
            gameManager.Add(game02);
            gameManager.Add(game03);
            gameManager.List();
            gameManager.Remove(game02);
            gameManager.Update(3, game03_update);

            gameManager.List();

            ICampaign campaign1 = new Campaign() { Id = 1, Name = "New Year", DiscountRate = 20 };
            ICampaign campaign2 = new Campaign() { Id = 2, Name = "Easter Week", DiscountRate = 30 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            campaignManager.List();

            campaignManager.ApplyDiscount(game01, campaign1);
            campaignManager.ApplyDiscount(game03, campaign2);


            gameManager.List();

            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(new Player() { TcNo = 1234567890, BirthYear = 1979, FirstName = "Serkan", Surname = "Okur" });
            playerManager.Add(new Player() { TcNo = 123456789, BirthYear = 1985, FirstName = "Erkan", Surname = "Okur" });
            playerManager.Add(new Player() { TcNo = 1234567890, BirthYear = 2012, FirstName = "Uzay", Surname = "Okur" });

            playerManager.List();

        }
    }
}
