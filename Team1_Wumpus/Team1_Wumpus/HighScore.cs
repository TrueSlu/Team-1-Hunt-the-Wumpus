using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class HighScore
    {
        public string Name { get; private set; }

        public string Cave { get; private set; }

        public int Score { get; private set; }

        public HighScore(string n, string c, int s)
        {
            Name = n;
            Cave = c;
            Score = s;
        }

        public HighScore() { }

        public override string ToString()
        {
            return "Name: " + Name + Environment.NewLine +
                "     Cave: " + Cave + Environment.NewLine +
                "     Score: " + Score + Environment.NewLine;
        }
    }
}
