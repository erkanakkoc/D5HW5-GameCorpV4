using D5HW5_GameCorpV4.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace D5HW5_GameCorpV4.Concrete
{
    class CampaignManager : ICampaignService
    {
        
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası ile %" + campaign.CampaignDiscount + " indirim sisteme eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası sistemden kaldırıldı");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası güncellendi");
        }
    }
}
