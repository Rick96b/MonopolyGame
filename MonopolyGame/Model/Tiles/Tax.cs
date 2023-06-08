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
        public double TaxRatio { get; private set; }
        public Tax(int index, string name, double taxRatio) :base(index, name)
        {
            this.TaxRatio = taxRatio;
        }

        public override string ActOnPlayer(Player player)
        {
            if (TaxRatio > 1)
            {
                player.DecrementMoney((int)(this.TaxRatio));
                return "\n" + this.Name + ": " + this.TaxRatio;
            }
            else
            {
                player.DecrementMoney((int)(player.Money * this.TaxRatio));
                return "\n" + this.Name + ": " + (int)(player.Money * this.TaxRatio);
            }
        }
    }
}
