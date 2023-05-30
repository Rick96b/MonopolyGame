using System;
using Microsoft.Xna.Framework.Input;
using MonopolyGame.Model;
using MonopolyGame.Model.Tiles;
using MonopolyGame.View.Tiles;

namespace MonopolyGame.Controller.States
{
    public class PlayerLandedState : State
    {
        public PlayerLandedState(State nextState) : base(nextState)
        {

        }

        public override void Execute()
        {
            int playerIndex = Board.CurrentPlayerIndex;
            int playerCurrentPosition = Board.players[playerIndex].CurrentPosition;

            Tile currentTile = Board.allTiles[playerCurrentPosition];

            EntryPoint.Game.renderer.NotificationText = "Игрок " + (playerIndex + 1) + "пришел на " + currentTile.Name;
            EntryPoint.Game.renderer.NotificationText += currentTile.ActOnPlayer(Board.players[playerIndex]);
            EntryPoint.Game.renderer.PlayerOneMoney = Board.players[0].Money + "$";
            EntryPoint.Game.renderer.PlayerTwoMoney = Board.players[1].Money + "$";


            if(currentTile is Street)
            {
                var currentTileAsStreet = currentTile as Street;
                if(currentTileAsStreet.Owner == null)
                {
                    ActivateBuyButton(playerCurrentPosition);
                } else
                {
                    StateMachine.ChangeState();
                }
            }

            else if (currentTile is ChanceCard || currentTile is Tax)
            {
                StateMachine.ChangeState();
            }

            else if (currentTile is SpecialTile)
            {
                var currentTileAsSpecial = currentTile as SpecialTile;

                if(currentTileAsSpecial.Index == 30)
                {
                    EntryPoint.Game.renderer.MovePlayer(Board.CurrentPlayerIndex, 30, 10);
                }
            }
            ActivateEndTurn();
        }

        private void ActivateEndTurn()
        {
            Button endTurnButton = EntryPoint.Game.renderer.EndTurnButton;
            EntryPoint.Game.renderer.NotificationText = "Вы хотите закончить ход?";

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
                endTurnButton.ChangeToClickedImage();
                StateMachine.ChangeState();
            }
        }

        private void ActivateBuyButton(int playerCurrentPosition)
        {
            Button buyButton = EntryPoint.Game.renderer.BuyButton;
            int currentPlayer = Board.CurrentPlayerIndex;
            bool mouseOverBuy = buyButton.sprite.Rectangle.Contains(Mouse.GetState().X, Mouse.GetState().Y);
            if (mouseOverBuy)
            {
                buyButton.ChangeToHoverImage();
            }
            else
            {
                buyButton.ChangeToUnactiveImage();
            }

            if (Mouse.GetState().LeftButton == ButtonState.Pressed && mouseOverBuy)
            {
                buyButton.ChangeToClickedImage();
                EntryPoint.Game.renderer.NotificationText = "Имущество куплено";
                Board.AddStreetToPlayer(currentPlayer, playerCurrentPosition);
                EntryPoint.Game.renderer.ShowTileOwner(currentPlayer, playerCurrentPosition);
                EntryPoint.Game.renderer.PlayerOneMoney = Board.players[0].Money + "$";
                EntryPoint.Game.renderer.PlayerTwoMoney = Board.players[1].Money + "$";

                StateMachine.ChangeState();
            }
        }
    }
}