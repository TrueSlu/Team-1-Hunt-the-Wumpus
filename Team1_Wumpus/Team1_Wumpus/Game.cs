using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class Game
    {

        public String CaveSystem { get; set; }
        public String Name { get; set; }
        public Game(String c, String n)
        {
            Cave.initializeCave(c);

            Name = n;
            CaveSystem = c;



        }

        public void MakeMove()
        {

        }
    }
}
