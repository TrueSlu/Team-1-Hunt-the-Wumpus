using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class TriviaSecret
    {
        public int Secret { get; set; }
        public int UUID { get; private set; }

        public TriviaSecret(int s, int id)
        {
            Secret = s;
            UUID = id;
        }


    }
}
