using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame.Model.Interfaces
{
    public interface IPlayer
    {
        int CurrentPosition { get; }
        int Index { get; }
        bool IsInJail { get; }
        int Money { get; }
        void SetPosition(int newPosition);
    }
}
