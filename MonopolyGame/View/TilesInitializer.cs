using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonopolyGame.View.Tiles
{
    public class TilesInitializer
    {
        public static Button CreateBuyButton(ContentManager content)
        {
            Texture2D buyActive = content.Load<Texture2D>("Buy");
            Texture2D buyClicked = content.Load<Texture2D>("BuyClicked");
            Texture2D buyHover = content.Load<Texture2D>("BuyHover");
            Rectangle buyRectangle = new Rectangle(450, 450, 80, 80);

            Sprite buyButtonSprite = new Sprite(buyRectangle, buyActive);

            return new Button(buyButtonSprite, buyHover, buyClicked, buyActive);
        }

        public static Button CreateRollButton(ContentManager content)
        {
            Texture2D rollActive = content.Load<Texture2D>("Roll");
            Texture2D rollClicked = content.Load<Texture2D>("RollClicked");
            Texture2D rollHover = content.Load<Texture2D>("RollActive");
            Rectangle rollRectangle = new Rectangle(300, 450, 120, 120);

            Sprite rollButtonSprite = new Sprite(rollRectangle, rollActive);

            return new Button(rollButtonSprite, rollHover, rollClicked, rollActive);
        }

        public static Button CreateEndTurnButton(ContentManager content)
        {
            Texture2D endTurnActive = content.Load<Texture2D>("Roll");
            Texture2D endTurnClicked = content.Load<Texture2D>("RollClicked");
            Texture2D endTurnHover = content.Load<Texture2D>("RollActive");
            Rectangle endTurnRectangle = new Rectangle(400, 515, 80, 80);

            Sprite endTurnButtonSprite = new Sprite(endTurnRectangle, endTurnActive);

            return new Button(endTurnButtonSprite, endTurnHover, endTurnClicked, endTurnActive);
        }

        public static Dice CreateDice(ContentManager content, int index)
        {
            Texture2D[] diceImages = new Texture2D[6];
            for (int i = 0; i < 6; i++)
            {
                diceImages[i] = content.Load<Texture2D>((i + 1).ToString());
            }
            Rectangle diceRectangle = new Rectangle(298 + index * 32, 560, 30, 30);
            Sprite diceSprite = new Sprite(diceRectangle, diceImages[0]);
            return new Dice(diceSprite, diceImages);
        }

        public static Background CreateBackground(ContentManager content)
        {
            Texture2D backgroundImage = content.Load<Texture2D>("board");
            Rectangle backgroundRectangle = new Rectangle(0, 0, 700, 700);

            Sprite backgroundSprite = new Sprite(backgroundRectangle, backgroundImage);

            return new Background(backgroundSprite);
        }

        public static PlayerUI CreatePlayer(ContentManager content, int index)
        {
            Texture2D playerImage = content.Load<Texture2D>("pawn" + index.ToString());
            Rectangle playerRectangle = new Rectangle(620, 600 + index * 30, 28, 28);

            Sprite playerSprite = new Sprite(playerRectangle, playerImage);

            return new PlayerUI(playerSprite, index);
        }

        public static TileOwnerNotification[] CreateTileOwnerNotifications(ContentManager content)
        {
            int xIncrement = 57;
            TileOwnerNotification[] tileNotifications = new TileOwnerNotification[28];
            Texture2D ownerOneImage = content.Load<Texture2D>("Owner1");
            tileNotifications[0] = new TileOwnerNotification(0, CreateNotificationSprite(0, xIncrement, ownerOneImage));
            tileNotifications[1] = new TileOwnerNotification(3, CreateNotificationSprite(3, xIncrement, ownerOneImage));
            tileNotifications[2] = new TileOwnerNotification(5, CreateNotificationSprite(5, xIncrement, ownerOneImage));
            tileNotifications[3] = new TileOwnerNotification(6, CreateNotificationSprite(6, xIncrement, ownerOneImage));
            tileNotifications[4] = new TileOwnerNotification(8, CreateNotificationSprite(8, xIncrement, ownerOneImage));
            tileNotifications[5] = new TileOwnerNotification(9, CreateNotificationSprite(9, xIncrement, ownerOneImage));
            tileNotifications[6] = new TileOwnerNotification(11, CreateNotificationSprite(11, xIncrement, ownerOneImage));
            tileNotifications[7] = new TileOwnerNotification(12, CreateNotificationSprite(12, xIncrement, ownerOneImage));
            tileNotifications[8] = new TileOwnerNotification(13, CreateNotificationSprite(13, xIncrement, ownerOneImage));
            tileNotifications[9] = new TileOwnerNotification(14, CreateNotificationSprite(14, xIncrement, ownerOneImage));
            tileNotifications[10] = new TileOwnerNotification(15, CreateNotificationSprite(15, xIncrement, ownerOneImage));
            tileNotifications[11] = new TileOwnerNotification(16, CreateNotificationSprite(16, xIncrement, ownerOneImage));
            tileNotifications[12] = new TileOwnerNotification(18, CreateNotificationSprite(18, xIncrement, ownerOneImage));
            tileNotifications[13] = new TileOwnerNotification(19, CreateNotificationSprite(19, xIncrement, ownerOneImage));
            tileNotifications[14] = new TileOwnerNotification(21, CreateNotificationSprite(21, xIncrement, ownerOneImage));
            tileNotifications[15] = new TileOwnerNotification(23, CreateNotificationSprite(23, xIncrement, ownerOneImage));
            tileNotifications[16] = new TileOwnerNotification(24, CreateNotificationSprite(24, xIncrement, ownerOneImage));
            tileNotifications[17] = new TileOwnerNotification(25, CreateNotificationSprite(25, xIncrement, ownerOneImage));
            tileNotifications[18] = new TileOwnerNotification(26, CreateNotificationSprite(26, xIncrement, ownerOneImage));
            tileNotifications[19] = new TileOwnerNotification(27, CreateNotificationSprite(27, xIncrement, ownerOneImage));
            tileNotifications[20] = new TileOwnerNotification(28, CreateNotificationSprite(28, xIncrement, ownerOneImage));
            tileNotifications[21] = new TileOwnerNotification(29, CreateNotificationSprite(29, xIncrement, ownerOneImage));
            tileNotifications[22] = new TileOwnerNotification(31, CreateNotificationSprite(31, xIncrement, ownerOneImage));
            tileNotifications[23] = new TileOwnerNotification(32, CreateNotificationSprite(32, xIncrement, ownerOneImage));
            tileNotifications[24] = new TileOwnerNotification(34, CreateNotificationSprite(34, xIncrement, ownerOneImage));
            tileNotifications[25] = new TileOwnerNotification(35, CreateNotificationSprite(35, xIncrement, ownerOneImage));
            tileNotifications[26] = new TileOwnerNotification(37, CreateNotificationSprite(37, xIncrement, ownerOneImage));
            tileNotifications[27] = new TileOwnerNotification(39, CreateNotificationSprite(39, xIncrement, ownerOneImage));
            return tileNotifications;
        }

        public static Rectangle[] CreateTilesColliders()
        {
            Rectangle[] tilesColliders = new Rectangle[40];
            int xIncrement = 57;
            int WINDOW_WIDTH = 700;
            int WINDOW_HEIGHT = 700;

            for(int i = 0; i < 40; i++)
            {
                tilesColliders[i] = CreateTileColliderRectangle(i, xIncrement, WINDOW_WIDTH, WINDOW_HEIGHT)
            }

            return tilesColliders;
        }

        private static Rectangle CreateTileColliderRectangle(int index, int xIncrement, int WINDOW_WIDTH, int WINDOW_HEIGHT)
        {
            if (index == 0)
            {
                return new Rectangle(607, 607, WINDOW_WIDTH-607, WINDOW_HEIGHT-607);
            } else if (index == 10)
            {
                return new Rectangle(0, 607, 93, WINDOW_HEIGHT - 607);
            } else if (index == 20)
            {
                return new Rectangle(0, 0, 93, 93);
            } else if (index == 30)
            {
                return new Rectangle(607, 0, WINDOW_WIDTH - 607, 93);
            } else if (index / 10 == 0)
            {
                return new Rectangle(607 - xIncrement * index, 607, xIncrement, WINDOW_HEIGHT - 607);
            }
            else if (index / 10 == 1)
            {
                return new Rectangle(0, 607 - xIncrement * (index % 10), 93, xIncrement);
            }
            else if (index / 10 == 2)
            {
                return new Rectangle(93 + xIncrement * ((index % 20) - 1), 0, xIncrement, 93);
            }
            else
            {
                return new Rectangle(607, 93 + xIncrement * ((index % 30) - 1), 93, xIncrement);
            }
        }

        private static Sprite CreateNotificationSprite(int index, int xIncrement, Texture2D notificationImage)
        {
            if(index / 10 == 0)
            {
                return new Sprite(new Rectangle(607 - xIncrement * index, 607, 15, 15), notificationImage);
            } else if (index / 10 == 1)
            {
                return new Sprite(new Rectangle(0, 607 - xIncrement * (index % 10), 15, 15), notificationImage);
            } else if (index / 10 == 2)
            {
                return new Sprite(new Rectangle(93 + xIncrement * ((index % 20) - 1), 0, 15, 15), notificationImage);
            } else
            {
                return new Sprite(new Rectangle(607, 93 + xIncrement * ((index % 30) - 1), 15, 15), notificationImage);
            }
        }
    }
}
