using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDesignPatternSoftDev
{
    public class Player
    {
        string name;
        int position;
        int token;
        bool reRoll;
        State state;
        int nbLap;

        public Player(string name, int token)
        {
            this.name = name;
            this.token = token;
            this.state = new StateFree(this);
            this.position = 0;
            this.nbLap = 0;
            this.reRoll = true;
        }
        public State State
        {
            get { return state; }
            set { state = value; }
        }
        public int Token
        {
            get { return token; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Position
        {
            get { return position; }
            set
            {
                position = value;
            }
        }
        public int NbLap
        {
            get { return nbLap; }
            set
            {
                nbLap = value;
            }
        }

        public bool ReRoll
        {
            get { return reRoll; }
            set { reRoll = value; }
        }

        public void Play()
        {
            state.Move();
        }
    }
}
