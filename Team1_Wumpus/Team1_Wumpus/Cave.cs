using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class Cave
    {
        public int CaveNumber { get; private set; }
        
        public Cave(int num)
        {
            CaveNumber = num;
        }
        public Cave() { }

        public int[] FindAdjacentCaveNumbers()
        {
            int[] caveNums = 
                new int[] {CaveNumber - 7, CaveNumber - 6,
                CaveNumber - 5, CaveNumber + 1,
                CaveNumber + 6, CaveNumber - 1 };

            for (int i=0; i<6; i++)
            {
                caveNums[i] %= 30;
                if (caveNums[i] == 0)
                {
                    caveNums[i] += 30;
                }
            }

            Array.Sort(caveNums);
            return caveNums;
        }
    }
}
