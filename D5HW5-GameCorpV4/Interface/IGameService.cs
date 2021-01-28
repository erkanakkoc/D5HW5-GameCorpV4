using D5HW5_GameCorpV4.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace D5HW5_GameCorpV4
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);

    }
}
