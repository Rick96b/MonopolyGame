using System;
using Microsoft.Xna.Framework.Input;
using MonopolyGame.Model;
using MonopolyGame.View.Tiles;

namespace MonopolyGame.Controller.States
{
    public class PlayerRollState : State
    {
        private Random rng;
        public PlayerRollState(State nextState) : base(nextState)
        {
            this.rng = new Random();
        }

        public override void Execute()
        {
            int currentPlayerPosition = Board.players[Board.CurrentPlayerIndex].CurrentPosition;

            int firstDiceNumber = rng.Next(1, 7);
            int secondDiceNumber = rng.Next(1, 7);
            int totalPositionToMove = firstDiceNumber + secondDiceNumber;

            PlayerMoveState.PlayerOldPosition = currentPlayerPosition;
            EntryPoint.Game.renderer.FirstDice.ChangeDiceImage(firstDiceNumber);
            EntryPoint.Game.renderer.SecondDice.ChangeDiceImage(secondDiceNumber);
            EntryPoint.Game.renderer.NotificationText = "Игрок " + (Board.CurrentPlayerIndex + 1) + " выкинул " + totalPositionToMove;
            Board.players[Board.CurrentPlayerIndex].SetPosition(currentPlayerPosition + totalPositionToMove);

            StateMachine.ChangeState();
        }
    }
}