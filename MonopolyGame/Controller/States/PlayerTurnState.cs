using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using MonopolyGame.Model;
using MonopolyGame.View.Tiles;

namespace MonopolyGame.Controller.States
{
    public class PlayerTurnState: State
    {
        public PlayerTurnState(State nextState) : base(nextState)
        {

        }

        public override void Execute()
        {
            if(Board.players[Board.CurrentPlayerIndex].TurnsInJail != 0)
            {
                Board.players[Board.CurrentPlayerIndex].TurnsInJail--;
                Board.CurrentPlayerIndex = (Board.CurrentPlayerIndex + 1) % Board.players.Count;
                Board.players[Board.CurrentPlayerIndex].SetPosition(10);
            }
            Button rollButton = EntryPoint.Game.renderer.RollButton;
            EntryPoint.Game.renderer.NotificationText = "Ход " + (Board.CurrentPlayerIndex + 1).ToString() + "'го игрока";

            bool mouseOverRoll = rollButton.sprite.Rectangle.Contains(Mouse.GetState().X, Mouse.GetState().Y);
            if (mouseOverRoll)
            {
                rollButton.ChangeToHoverImage();
            }
            else
            {
                rollButton.ChangeToUnactiveImage();
            }

            if(Mouse.GetState().LeftButton == ButtonState.Pressed && mouseOverRoll)
            {
                rollButton.ChangeToClickedImage();
                EntryPoint.Game.renderer.shouldPlayerMove = true;
                StateMachine.ChangeState();
            }
        }
    }
}
