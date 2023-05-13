using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Model.Interfaces;
using MonopolyGame.Model.Players;

namespace MonopolyGame.Model.Tiles
{
    public class ChanceCard: Tile, ITile
    {
        public ChanceCard(int index, string name):base(index, name)
        {

        }

        public override string ActOnPlayer(Player player)
        {
            return ChanceCardGenerator.GenerateRandomCart(player);
        }
    }
}
