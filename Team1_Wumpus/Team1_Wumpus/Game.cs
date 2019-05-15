using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class Game
    {

        public int CaveNumber { get; set; }
        public String Name { get; set; }
        public String Player { get; private set; }
        public CaveSystem GameCave { get; set; }
        public

        Game(String n, int c)
        {

            Name = n;
            CaveNumber = c;



        }

        public void MakeMove()
        {

        }
    }
}
