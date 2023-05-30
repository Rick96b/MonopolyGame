using System;
using Microsoft.Xna.Framework.Input;
using MonopolyGame.Model;
using MonopolyGame.View.Tiles;

namespace MonopolyGame.Controller.States
{
    public class PlayerMoveState : State
    {
        public static int PlayerOldPosition { get; set; }
        public PlayerMoveState(State nextState) : base(nextState)
        {

        }

        public override void Execute()
        {
            EntryPoint.Game.renderer.MovePlayer(Board.CurrentPlayerIndex,
                PlayerOldPosition,
                Board.players[Board.CurrentPlayerIndex].CurrentPosition);

            if(!EntryPoint.Game.renderer.shouldPlayerMove)
            {
                StateMachine.ChangeState();
            }
        }
    }
}