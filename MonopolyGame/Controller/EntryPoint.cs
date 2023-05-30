using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Controller;

namespace MonopolyGame
{
    public static class EntryPoint
    {
        public static MonopolyGameController Game;
        static void Main()
        {
            using (Game = new MonopolyGameController())
                Game.Run();
        }
    }
}
