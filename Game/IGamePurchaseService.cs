using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GameProject
{
    interface IGamePurchaseService
    {
        void Purchase(Gamer gamer, Games games, Campaign campaign);
    }
}
