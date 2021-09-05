using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası eklendi.\nKampanya indirimi %" + campaign.CampaignDiscount);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName +" kampanyası silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanya güncellendi.");
            Console.WriteLine("Güncel Kampanya indirimi : %" + campaign.CampaignDiscount);
        }
    }
}
