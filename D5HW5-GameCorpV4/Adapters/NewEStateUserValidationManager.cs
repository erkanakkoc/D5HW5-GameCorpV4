using System;
using System.Collections.Generic;
using System.Text;

namespace D5HW5_GameCorpV4
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            return true;
        }
    }
}
