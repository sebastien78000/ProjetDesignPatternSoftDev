using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDesignPatternSoftDev
{
    public class Case
    {
        string name;
        int index;
        string colour;

        public Case(string name, int index, string colour)
        {
            this.name = name;
            this.index = index;
            this.colour = colour;
        }
    }
}
