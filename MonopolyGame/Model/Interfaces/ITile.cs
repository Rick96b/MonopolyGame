using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Model.Players;

namespace MonopolyGame.Model.Interfaces
{
    internal interface ITile
    {
        int Index { get; }
        string Name { get; }
        string ActOnPlayer(Player player);
    }
}
