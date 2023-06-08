using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MonopolyGame.Model;

namespace MonopolyGame.Controller.States
{
    public class EndGameState : State
    {
        public static int PlayerOldPosition { get; set; }
        public EndGameState(State nextState) : base(nextState)
        {

        }

        public override void Execute()
        {
            var loosedPlayer = Board.players.Where(player => player.Money < 0).ToArray()[0];
            EntryPoint.Game.renderer.NotificationText = "Игрок " + (Board.CurrentPlayerIndex + 1) + " проиграл!";
        }
    }
}