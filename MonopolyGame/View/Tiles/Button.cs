using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonopolyGame.View.Tiles
{
    public class Button
    {
        public Sprite sprite;
        public Texture2D hoverImage { get; set; }
        public Texture2D clickedImage { get; set; }
        public Texture2D unactiveImage { get; set; }

        public Button(Sprite sprite, Texture2D hoverImage, Texture2D clickedImage, Texture2D unactiveImage)
        {
            this.sprite = sprite;
            this.hoverImage = hoverImage;
            this.clickedImage = clickedImage;
            this.unactiveImage = unactiveImage;
        }

        public void ChangeToHoverImage()
        {
            this.sprite.Image = this.hoverImage;
        }

        public void ChangeToClickedImage()
        {
            this.sprite.Image = this.clickedImage;
        }

        public void ChangeToUnactiveImage()
        {
            this.sprite.Image = this.unactiveImage;
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(this.sprite.Image, this.sprite.Rectangle, Color.White);
        }
    }
}
