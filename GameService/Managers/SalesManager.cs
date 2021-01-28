using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class SalesManager
    {
        public void Sell(Customer customer , Sales sales , ICampaignServices campaignServices)
        {
            Console.WriteLine(customer.Adi);
            Console.WriteLine(sales.SalesId);
            campaignServices.MakeCampaign();
        }

    }
}
