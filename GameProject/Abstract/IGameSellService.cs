using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameSellService
    {

        void Sell(Gamer gamer, Game game, Campaign campaign);

    }
}
