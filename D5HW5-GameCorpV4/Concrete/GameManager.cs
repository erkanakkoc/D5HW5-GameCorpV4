using D5HW5_GameCorpV4.Concrete;
using D5HW5_GameCorpV4.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace D5HW5_GameCorpV4
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun " + game.GamePrice + " fiyatla sisteme eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun güncellendi");
        }
    }
}
