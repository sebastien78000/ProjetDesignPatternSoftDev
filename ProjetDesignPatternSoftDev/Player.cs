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
        State state; 

        public Player(string name, int token)
        {
            this.name = name;
            this.token = token;
            this.state = new StateFree(this);
            this.position = 0;
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
        }

        public void Play()
        {
            state.Move();
        }
    }
}
