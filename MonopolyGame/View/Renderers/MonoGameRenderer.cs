using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonopolyGame.View.Tiles;

namespace MonopolyGame.View.Renderers
{
    public class MonoGameRenderer: AbstractRenderer
    {
        private ContentManager Content = EntryPoint.game.Content;
        private SpriteBatch SpriteBatch;

        public Button BuyButton;
        public Button RollButton;
        public Button EndTurnButton;

        public Dice FirstDice;
        public Dice SecondDice;

        public List<PlayerUI> PlayersUI;
        public PlayerUI FirstPlayer;
        public PlayerUI SecondPlayer;
        private int Velocity;
        private Rectangle TileDestination;
        public bool shouldPlayerMove;

        private Background Background;
        public TileOwnerNotification[] TileOwnerNotifications;
        public Rectangle[] TileColliders;
        private SpriteFont font;

        public string NotificationText;
        public string PlayerOneMoney;
        public string PlayerTwoMoney;

        public MonoGameRenderer()
        {
            this.Background = TilesInitializer.CreateBackground(Content);

            this.BuyButton = TilesInitializer.CreateBuyButton(Content);
            this.RollButton = TilesInitializer.CreateRollButton(Content);
            this.EndTurnButton = TilesInitializer.CreateEndTurnButton(Content);

            this.FirstDice = TilesInitializer.CreateDice(Content, 1);
            this.SecondDice = TilesInitializer.CreateDice(Content, 2);

            this.FirstPlayer = TilesInitializer.CreatePlayer(Content, 1);
            this.SecondPlayer = TilesInitializer.CreatePlayer(Content, 2);

            this.PlayersUI = new List<PlayerUI>();
            this.PlayersUI.Add(FirstPlayer);
            this.PlayersUI.Add(SecondPlayer);

            this.TileOwnerNotifications = TilesInitializer.CreateTileOwnerNotifications(Content);
            this.TileColliders = TilesInitializer.CreateTilesColliders();

            this.Velocity = 400;
            this.shouldPlayerMove = false;

            this.NotificationText = "Монополия";
            this.PlayerOneMoney = "1500$";
            this.PlayerTwoMoney = "1500$";
            this.font = Content.Load<SpriteFont>("Font");
        }

        public override void DrawBoard()
        {
            this.SpriteBatch = EntryPoint.game.SpriteBatch;

            Background.Draw(SpriteBatch);

            BuyButton.Draw(SpriteBatch);
            RollButton.Draw(SpriteBatch);
            EndTurnButton.Draw(SpriteBatch);

            FirstDice.Draw(SpriteBatch);
            SecondDice.Draw(SpriteBatch);

            foreach(var player in PlayersUI)
            {
                player.Draw(SpriteBatch);
            }

            foreach(var notification in TileOwnerNotifications)
            {
                notification.Draw(SpriteBatch);
            }

            SpriteBatch.DrawString(font, NotificationText, new Vector2(105, 105), Color.Black);
            SpriteBatch.DrawString(font, PlayerOneMoney, new Vector2(150, 525), Color.Black);
            SpriteBatch.DrawString(font, PlayerTwoMoney, new Vector2(150, 560), Color.Black);
        }

        public override void MovePlayer(int playerIndex, int currentPosition, int newPosition)
        {
            PlayerUI currentPlayer = PlayersUI[playerIndex];
            TileDestination = TileColliders[newPosition];
            if(TileDestination.Contains(currentPlayer.sprite.Rectangle))
            {
                this.shouldPlayerMove = false;
            } else
            {
                if(currentPlayer.sprite.Rectangle.Y > 606 && currentPlayer.sprite.Rectangle.X > 30)
                {
                    currentPlayer.sprite.Rectangle.X -= (int)(Velocity * EntryPoint.game.Elapsed);
                } else if (currentPlayer.sprite.Rectangle.Y > 30 && currentPlayer.sprite.Rectangle.X <= 50)
                {
                    currentPlayer.sprite.Rectangle.Y -= (int)(Velocity * EntryPoint.game.Elapsed);
                } else if (currentPlayer.sprite.Rectangle.Y <= 50 && currentPlayer.sprite.Rectangle.X < 650)
                {
                    currentPlayer.sprite.Rectangle.X += (int)(Velocity * EntryPoint.game.Elapsed);
                } else if (currentPlayer.sprite.Rectangle.Y < 680 && currentPlayer.sprite.Rectangle.X >= 620)
                {
                    currentPlayer.sprite.Rectangle.Y += (int)(Velocity * EntryPoint.game.Elapsed);
                }
            }
        }

        public override void ShowTileOwner(int playerIndex, int currentPlayerPosition)
        {
            for(int i = 0; i < this.TileOwnerNotifications.Count(); i++)
            {
                if (this.TileOwnerNotifications[i].BoardIndex == currentPlayerPosition)
                {
                    this.TileOwnerNotifications[i].setOwner(Content, playerIndex + 1);
                    break;
                }
            }
        }
    }
}
