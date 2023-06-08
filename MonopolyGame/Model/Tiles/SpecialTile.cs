using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Model.Interfaces;
using MonopolyGame.Model.Players;

namespace MonopolyGame.Model.Tiles
{
    public class SpecialTile: Tile, ITile
    {
        public SpecialTile(int index, string name):base(index, name)
        {

        }

        public override string ActOnPlayer(Player player)
        {
            if (this.Index == 0)
            {
                return "\nТы прошел начало круга";
            }
            else if (this.Index == 10)
            {
                return "\nТы посетил деканат. \nПока что просто посетил.";
            }
            else if (this.Index == 20)
            {
                return "\nБесплатная стоянка. \nНичего не произошло";
            }
            else
            {
                player.TurnsInJail = 3;
                return "\nТебя вызвали на приемную комиссию! \nТы пропустишь следующие 3 хода";
            }
        }
    }
}
