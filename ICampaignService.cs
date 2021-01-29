using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void BuyCampaign(Game game, Campaign campaign, Gamer gamer);
    }
}
