using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    class CaveSystem
    {
        public Cave[] System = new Cave[30];
    }
    class Cave
    {
        public int CaveNumber { get; private set; }
        public int[] AdjacentCaves { get; private set; } = new int[6];
        public int[] ConnectedCaves { get; private set; } = new int[6];

        public Cave(int c, int[] ac, int[] cc)
        {
            if (ac.Length != 6 || cc.Length != 6)
            {
                return;
            }
            else
            {
                CaveNumber = c;
                AdjacentCaves = ac;
                ConnectedCaves = cc;
            }
        }

        public Cave() { }

        public void CalculateAdjacentCaves()
        {
            // north cave
            int northCave = CaveNumber - 6;
            // northeast cave
            int northEastCave;
            if (CaveNumber % 2 == 0 && CaveNumber % 6 != 0)
            {
                northEastCave = CaveNumber - 1;
            }
            else if (CaveNumber % 2 == 1 || CaveNumber % 6 == 0)
            {
                northEastCave = CaveNumber - 5;
            }

        }
    }
}
