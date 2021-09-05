using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSellManager : IGameSellService
    {
        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName + " " + gamer.LastName + " satın aldı.");
            Console.WriteLine("Uygulana indirim fiyatı: " + game.GamePrice*(campaign.CampaignDiscount/100)+"TL");

        }
    }
}
