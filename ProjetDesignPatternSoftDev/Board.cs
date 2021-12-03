using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDesignPatternSoftDev
{

    public class Board
    {
        List<Case> boardList = new List<Case>();

        public Board()
        {
            for (int i=0;i<40;i++)
            {
                nameCase recup = (nameCase)i;
                string temp = recup.ToString();
                Case cases = new Case(temp, i);
                boardList.Add(cases);
            }
            
        }

        public List<Case> BoardList
        {
            get { return this.boardList; }
            set { this.boardList = value; }
        }
    }
    
}
