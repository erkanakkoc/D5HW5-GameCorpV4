using System;
using System.Collections.Generic;
using System.Text;

namespace D5HW5_GameCorpV4
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.BirthYear == 1985 && user.FirstName == "ENGİN" && user.LastName == "DEMİROĞ" && user.IdentityId == "1234567890")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
