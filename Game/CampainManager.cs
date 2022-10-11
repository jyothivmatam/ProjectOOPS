using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Cadd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " Campaign added");
        }

        public void Cdelete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " Camapign deleted");
        }

        public void Cupdate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " Campaign information has Updated");
        }
    }
}
