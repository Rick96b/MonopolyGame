using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Model.Interfaces;
using MonopolyGame.Model.Players;

namespace MonopolyGame.Model.Tiles
{
    public class Tax: Tile, ITile
    {
        public int TaxAmount { get; private set; }
        public Tax(int index, string name, int taxAmount):base(index, name)
        {
            this.TaxAmount = taxAmount;
        }

        public override string ActOnPlayer(Player player)
        {
            player.DecrementMoney(this.TaxAmount);
            return this.Name + ": " + this.TaxAmount;
        }
    }
}
