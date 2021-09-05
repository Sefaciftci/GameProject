using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine( "Oyun adı: " + game.GameName
                +" Fiyat: " + game.GamePrice+"TL "
                +" Kategori: "+game.GameCategory+" Oyun basarıyla eklendi...");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName+" silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName+"  Guncellendi");
        }
    }
}
