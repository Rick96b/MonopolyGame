using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonopolyGame.View.Tiles
{
    public class PlayerUI
    {
        public Sprite sprite;
        public int Index { get; private set; }

        public PlayerUI(Sprite sprite, int index)
        {
            this.sprite = sprite;
            this.Index = index;
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(this.sprite.Image, this.sprite.Rectangle, 
                Color.White);
        }
    }
}
