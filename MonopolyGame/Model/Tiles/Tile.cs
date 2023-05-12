using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Model.Interfaces;
using MonopolyGame.Model.Players;

namespace MonopolyGame.Model.Tiles
{
    public abstract class Tile: ITile
    {
        public Tile(int index, string name)
        {
            this.Index = index;
            this.Name = name;
        }

        public int Index { get; private set; }
        public string Name { get; private set; }
        public abstract string ActOnPlayer(Player player);
    }
}
