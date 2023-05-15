using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonopolyGame.View.Tiles
{
    public class Background
    {
        public Sprite sprite;

        public Background(Sprite sprite)
        {
            this.sprite = sprite;
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(this.sprite.Image, this.sprite.Rectangle, Color.White);
        }
    }
}
