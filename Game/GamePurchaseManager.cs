using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GameProject
{
    class GamePurchaseManager : IGamePurchaseService
    {


        public void Purchase(Gamer gamer, Games games, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + games.Name + " the game " + campaign.CampaingName + " with the campaign" +
                " succesfully bought.");
        }
    }
}
