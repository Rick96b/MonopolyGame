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
    public class TileOwnerNotification
    {
        public Sprite sprite;
        public bool IsActive { get; set; } = false;
        public int BoardIndex { get; private set; }

        public TileOwnerNotification(int index, Sprite sprite)
        {
            this.sprite = sprite;
            this.BoardIndex = index;
        }

        public void setOwner(ContentManager content, int ownerIndex)
        {
            this.IsActive = true;
            this.sprite.Image = content.Load<Texture2D>("pawn" + ownerIndex.ToString());
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            if(IsActive)
            {
                _spriteBatch.Draw(this.sprite.Image, this.sprite.Rectangle, Color.White);
            }
        }
    }
}
