using System;
using System.Collections.Generic;
using System.Text;
using D5HW5_GameCorpV4.Concrete;

namespace D5HW5_GameCorpV4
{
    interface IUserService     //SOYUT ÇÜNKÜ YAPTIĞI İŞLEM GÖZLE GÖRÜLÜR ŞEKİLDE DEĞİL
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);

    }
}
