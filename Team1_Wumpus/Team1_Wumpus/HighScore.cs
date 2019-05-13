using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class HighScore
    {

        //class for the HighScoreManager to create new instantiations of
        public int Score { get; set; }
        public String Name { get; set; }

        HighScore(int s, String n)
        {
            Score = s;
            Name = n;
        }


    }
}
