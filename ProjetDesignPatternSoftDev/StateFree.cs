using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDesignPatternSoftDev
{
    public class StateFree : State
    {
        public StateFree(State state):this(state.P)
        {
            this.counter = 0;
        }
        public StateFree(Player player)
        {
            this.counter = 0;
            this.p = player;
        }
        public override bool Move()
        {
            throw new NotImplementedException();
        }
    }
}
