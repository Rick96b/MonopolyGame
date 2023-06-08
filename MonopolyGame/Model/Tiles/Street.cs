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
        public bool isUpgraded { get; set; }

        public override string ActOnPlayer(Player player)
        {
            if (this.Owner == player)
            {
                return "\nВы уже владеете " + this.Name + ".";
            } else if (this.Owner == null)
            {
                return "\n" + this.Name + " доступна для покупки.";
            } else
            {
                if(this.Neighbourhood== NeighbourhoodTypes.JunkFood)
                {
                    int ratio = player.Streets
                        .Where(street => street.Neighbourhood == NeighbourhoodTypes.JunkFood)
                        .ToArray()
                        .Length;

                    player.DecrementMoney(this.Rent * (int)Math.Pow(2, ratio - 1));
                    this.Owner.IncrementMoney(this.Rent * (int)Math.Pow(2, ratio - 1));
                    return String.Format("\n {0} Владеет улицей {1}\nВы заплатили ему {2}", player.Index, this.Name, this.Rent * Math.Pow(2,ratio - 1));
                }

                else if(this.Neighbourhood == NeighbourhoodTypes.WaterStation)
                {
                    var rnd = new Random();
                    player.DecrementMoney(this.Rent + rnd.Next(1, 8)*15);
                    this.Owner.IncrementMoney(this.Rent + rnd.Next(1, 8) * 15);
                    return String.Format("\n {0} Владеет общажным водопроводом {1}\nВы заплатили ему {2}", player.Index, this.Name, this.Rent + rnd.Next(1, 8) * 15);
                }

                else if (this.Neighbourhood == NeighbourhoodTypes.ElectricityStation)
                {
                    var rnd = new Random();
                    player.DecrementMoney(this.Rent + rnd.Next(1, 8) * 15);
                    this.Owner.IncrementMoney(this.Rent + rnd.Next(1, 8) * 15);
                    return String.Format("\n {0} Владеет общажным светом {1}\nВы заплатили ему {2}", player.Index, this.Name, this.Rent + rnd.Next(1, 8) * 15);
                }


                player.DecrementMoney(this.Rent);
                this.Owner.IncrementMoney(this.Rent);
                return String.Format("\n {0} Владеет улицей {1}\nВы заплатили ему {2}", player.Index, this.Name, this.Rent);
            }
        }

        public void Upgrade(double ratio)
        {
            this.Rent = (int)(this.Rent * ratio);
            isUpgraded = true;
        }
    }
}
