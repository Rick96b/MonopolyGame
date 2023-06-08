using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Model.Interfaces;
using MonopolyGame.Model.Tiles;

namespace MonopolyGame.Model.Players
{
    public class Player: IPlayer
    {
        public const int INITIAL_PLAYER_MONEY = 1500;
        public const int TOTAL_NUMBER_OF_TILES = 40;

        public Player(int index)
        {
            this.Index = index;
        }

        public void SetPosition(int newPosition)
        {
            int modifiedPosition = newPosition;

            if (modifiedPosition < 0)
            {
                modifiedPosition += TOTAL_NUMBER_OF_TILES;
            }
            if(modifiedPosition >= TOTAL_NUMBER_OF_TILES)
            {
                modifiedPosition -= TOTAL_NUMBER_OF_TILES;
                this.IncrementMoney(200);
            }
            this.CurrentPosition = modifiedPosition;
        }

        public void IncrementMoney(int amount)
        {
            this.Money += amount;
        }

        public void DecrementMoney(int amount)
        {
            this.Money -= amount;
        }

        public List<Street> Streets { get; private set; } = new List<Street>();

        public int CurrentPosition { get; private set; } = 0;

        public int Index { get; private set; } = 0;

        public int TurnsInJail { get; set; } = 0;

        public int Money { get; private set; } = INITIAL_PLAYER_MONEY;
    }
}
