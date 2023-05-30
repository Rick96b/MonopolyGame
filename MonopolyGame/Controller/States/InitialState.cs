using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Model;
using MonopolyGame.View.Renderers;

namespace MonopolyGame.Controller.States
{
    public class InitialState: State
    {
        public InitialState(State nextState) : base(nextState)
        {

        }

        public override void Execute()
        {
            Board.InitializeBoard();
        }
    }
}