using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class CampaignManager
    {
        public void Add(ICampaignServices campaign)
        {
            Console.WriteLine("Campaign added.");
        }

        public void Update(ICampaignServices campaign)
        {
            Console.WriteLine("Campaign update.");
        }

        public void Delete(ICampaignServices campaign)
        {
            Console.WriteLine("Campaign delete.");
        }
    }
}
