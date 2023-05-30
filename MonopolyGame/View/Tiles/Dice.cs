using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonopolyGame.View.Tiles
{
    public class Dice
    {
        public Sprite sprite;
        public Texture2D[] valueSprites = new Texture2D[6];

        public Dice(Sprite sprite, Texture2D[] valueSprites)
        {
            this.sprite = sprite;
            this.valueSprites = valueSprites;
        }
        public void ChangeDiceImage(int diceValue)
        {
            this.sprite.Image = valueSprites[diceValue - 1];
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(this.sprite.Image, this.sprite.Rectangle, Color.White);
        }
    }
}
