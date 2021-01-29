using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameManagerService
    {
        
        public void Add(Game game)
        {
            Console.WriteLine("Game added.");
        }

        
        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted.");
        }

       
        public void Update(Game game)
        {
            Console.WriteLine("Game updated.");
        }
    }
}
