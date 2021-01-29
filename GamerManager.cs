using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerManagerService
    {
        public GamerManager(GamerValidationManager gamerValidationManager)
        {
            GamerValidationManager = gamerValidationManager;
        }

        public GamerValidationManager GamerValidationManager { get; }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer added.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated.");
        }
    }
}
