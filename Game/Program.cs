using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adding Gamers with first stage verification
            Gamer gamer = new Gamer();
            {
                gamer.Id = 1;
                gamer.BirthYear = 1985;
                gamer.FirstName = "ENGİN";
                gamer.LastName = "DEMİROĞ";
                gamer.IdentityNumber = 12345;
            }

            GamerManager gamerManager = new GamerManager(new NEwEStateUserValidationManager());
            gamerManager.Add(gamer);

            /*------------------------------------------------
             Second stage Campaigns*/

            Campaign campaign1 = new Campaign();
            {
                campaign1.Id = 1;
                campaign1.CampaingName = "Winter Sale";
                campaign1.RateOfDiscount = 22.5;
            }

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Cadd(campaign1);

            /*------------------------------------------------
             Third stage game sale*/

            Games game1 = new Games();
            {
                game1.Id = 1;
                game1.Name = "CS GO";
                game1.Platform = "FPS";
                game1.Price = 15;
                game1.Rating = 9.1;
            }
            GamePurchaseManager gamePurchaseManager = new GamePurchaseManager();
            gamePurchaseManager.Purchase(gamer, game1, campaign1);



        }
    }
}
