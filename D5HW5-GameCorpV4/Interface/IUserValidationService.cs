using System;
using System.Collections.Generic;
using System.Text;
using D5HW5_GameCorpV4.Concrete;

namespace D5HW5_GameCorpV4
{
    //İlk önce şablon oluşturmak için interface oluştur.
    interface IUserValidationService
    {
        bool Validate(User user);
    }
}
