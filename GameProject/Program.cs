using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            


            //Oyuncular tanımlanıyor
            Gamer gamer1 = new Gamer()
            {
                FirstName = "SEFA",
                LastName = "CİFTCİ",
                BirthYear = 2000,
                Id = 1,
                NationalIdentity = 12345
            
            };

            Gamer gamer2 = new Gamer()
            {
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                BirthYear = 1985,
                Id = 2,
                NationalIdentity = 54321

            };


            //Oyunlar tanımlanıyor 
            Game game1 = new Game()
            {
                GameName = "God Of War",
                GamePrice = 235,
                GameCategory = "Stories Game"
            };

            Game game2 = new Game()
            {
                GameName = "Valorant",
                GamePrice = 0,
                GameCategory = "First Person Game"
            };


            //Kampanyalar tanımlanıyor

            Campaign campaign1 = new Campaign()
            {
                CampaignName = "Okul Başlıyor İndirimi",
                CampaignDiscount = 25
            };

            Campaign campaign2 = new Campaign()
            {
                CampaignName = "Yaza Merhaba",
                CampaignDiscount = 30
            };


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);

            Console.WriteLine("-----------------------");

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game2);

            Console.WriteLine("-----------------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Console.WriteLine("-----------------------");

            GameSellManager gameSellManager = new GameSellManager();
            gameSellManager.Sell(gamer1, game1,campaign1);
            gameSellManager.Sell(gamer2,game2,campaign2);



        }
    }
}
