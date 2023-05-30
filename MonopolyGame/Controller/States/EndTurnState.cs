using System;
using Microsoft.Xna.Framework.Input;
using MonopolyGame.Model;
using MonopolyGame.View.Tiles;

namespace MonopolyGame.Controller.States
{
    public class EndTurnState : State
    {
        public static int PlayerOldPosition { get; set; }
        public EndTurnState(State nextState) : base(nextState)
        {

        }

        public override void Execute()
        {
            ActivateEndTurn();
        }

        private void ActivateEndTurn()
        {
            Button endTurnButton = EntryPoint.Game.renderer.EndTurnButton;
            bool mouseOverEndTurn = endTurnButton.sprite.Rectangle.Contains(Mouse.GetState().X, Mouse.GetState().Y);
            if (mouseOverEndTurn)
            {
                endTurnButton.ChangeToHoverImage();
            }
            else
            {
                endTurnButton.ChangeToUnactiveImage();
            }

            if (Mouse.GetState().LeftButton == ButtonState.Pressed && mouseOverEndTurn)
            {
                Board.CurrentPlayerIndex = (Board.CurrentPlayerIndex + 1) % Board.players.Count;
                endTurnButton.ChangeToClickedImage();
                StateMachine.ChangeState();
            }
        }
    }
}
