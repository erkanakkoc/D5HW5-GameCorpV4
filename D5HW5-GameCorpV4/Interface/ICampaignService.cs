using D5HW5_GameCorpV4.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace D5HW5_GameCorpV4.Interface
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
