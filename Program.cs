using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                GamerId = 1,
                GamerName="TUGAY",
                GamerIdentityNo="12345",
                SureName="SENGUL",
                GamerBirthYear="1993"
            };
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(gamer);

            Game game = new Game { GameName = " Call Of Duty", GamePrice = 100, GameType = "War" };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            GameOwnerManager gameOwnerManager = new GameOwnerManager();
            gameOwnerManager.ownGame(game, gamer);
            Campaign campaign = new Campaign { CampaignName = "Şubeye özel indirim", CampaignDiscountAmount = "60: " };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.BuyCampaign(game,campaign,gamer);

        }
    }
}
