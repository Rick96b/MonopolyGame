using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonopolyGame.View.Tiles
{
    public class Sprite
    {
        public Sprite(Rectangle rectangle, Texture2D image)
        {
            Rectangle = rectangle;
            Image = image;
        }

        public Rectangle Rectangle;
        public Texture2D Image { get; set; }
    }
}
