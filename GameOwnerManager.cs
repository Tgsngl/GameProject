using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameOwnerManager : IGameOwnerService
    {
        public void ownGame(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName+","+game.GameName+" oyununu satın aldı.");
        }
    }
}
