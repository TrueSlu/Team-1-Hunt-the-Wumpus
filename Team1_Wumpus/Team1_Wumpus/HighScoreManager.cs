using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class HighScoreManager
    {
        List<HighScore> scores = new List<HighScore>();

        public void AddNewHighScore(HighScore hs)
        {
            scores.Add(hs);
        }

        public double GetScore(int index)
        {
            return scores[index].Score;
        }

        public List<HighScore> GetHighScores()
        {
            List<HighScore> score = new List<HighScore>();
            foreach (HighScore hs in scores)
            {
                scores.Add(hs);
            }

            return score;
        }
    }
}
