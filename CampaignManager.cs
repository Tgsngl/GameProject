using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void BuyCampaign(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName+" adlı kullanıcı"+game.GameName+" oyununu % "+campaign.CampaignDiscountAmount+campaign.CampaignName+" kampanyasından yararlanarak bu oyunu satın aldı.");
        }
    }
}
