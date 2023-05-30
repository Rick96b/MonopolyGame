using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.View.Renderers;

namespace MonopolyGame.Controller.States
{
    public abstract class State
    {
        public State(State nextState)
        {
            this.NextState = nextState;
        }

        public State NextState { get; set; }
        public abstract void Execute();
        public void Draw(MonoGameRenderer renderer)
        {
            renderer.DrawBoard();
        }

    }
}
