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
                player.IncrementMoney(200);
                return "\nТы прошел начало круга.\nПолучи 200$";
            }
            else if (this.Index == 10)
            {
                return "\nТы посетил тюрьму";
            }
            else if (this.Index == 20)
            {
                return "\nБесплатная стоянка. \n Ничего не произошло";
            }
            else
            {
                player.TurnsInJail = 3;
                return "\nТы попал в тюрьму! \nТы пропустишь следующие 3 хода";
            }
        }
    }
}
