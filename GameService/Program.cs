using System;

namespace GameService
{
    class Program
    {
        static void Main(string[] args)
        {
            Member m1 = new Member()
            {
                Id = 1,
                Adi = "Burak",
                Soyadi = "Erturk",
                DogumTarihi = "29.05.1999",
                MusteriNo = "13225",
                TcNo = "131232323"
            };

            Sales sales = new Sales();
            sales.SalesId = 1;
            sales.Sellby = DateTime.Now;
            sales.SalePrice = 20;

            ICampaignServices oneStYearCampaign = new OneStYearCampaign();

            MemberManager memberManager = new MemberManager();
            memberManager.Add(m1);

            CampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(oneStYearCampaign);

            oneStYearCampaign.MakeCampaign();

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(m1, sales, oneStYearCampaign);

            Record record = new Record();
            record.RecordId = 1;
            record.RecordDate = DateTime.Now;
            record.VerificationStatus = true;
            RecordManager recordManager = new RecordManager();
            IVerificationService verificationService = new E_DevletVerification();
            recordManager.Register(record, verificationService);


        }
    }
}
