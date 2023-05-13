using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Model.Enums;
using MonopolyGame.Model.Interfaces;
using MonopolyGame.Model.Players;

namespace MonopolyGame.Model.Tiles
{
    public class Street: Tile, ITile
    {
        public Street(int index, string name, NeighbourhoodTypes neighbourhood, int price, int rent):base(index,name)
        {
            this.Neighbourhood = neighbourhood;
            this.Price = price;
            this.Rent = rent;
            this.Owner = null;
        }

        public NeighbourhoodTypes Neighbourhood { get; set; }
        public Player Owner { get; set; }
        public int Price { get; set; }
        public int Rent { get; set; }

        public override string ActOnPlayer(Player player)
        {
            if (this.Owner == player)
            {
                return "Вы уже владеете " + this.Name + ".";
            } else if (this.Owner == null)
            {
                return this.Name + "доступна \nдля покупки.";
            } else
            {
                player.DecrementMoney(this.Rent);
                this.Owner.IncrementMoney(this.Rent);
                return String.Format("{0} Владеет улицей {1}\nВы заплатили ему {2}", player.Index, this.Name, this.Rent);
            }
        }
    }
}
