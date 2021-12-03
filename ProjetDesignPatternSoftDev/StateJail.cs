using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDesignPatternSoftDev
{
    public class StateJail : State
    {
        public StateJail(State state) : this(state.P)
        {
            this.counter = 0;
        }
        public StateJail(Player player)
        {
            this.counter = 0;
            this.p = player;
        }
        public override bool Move()
        {
            Dice.Roll();
            int[] actualVal = Dice.Value;
            if (actualVal[0] == actualVal[1])
            {

            }
            return true;
        }
    }
}
