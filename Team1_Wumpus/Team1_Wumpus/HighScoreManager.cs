using System;
using System.Collections.Generic;
using System.IO;
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

        public void WriteToFile()
        {
            string[] scores = { "Highest score", "Second-highest score", "Third-highest score" };
            
            string FetchScores =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(FetchScores, "WriteLines.txt")))
            {
                foreach (string score in scores)
                    outputFile.WriteLine(score);
            }

        }

        public void ReadToFile()
        {
            try
            {   
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    String score = sr.ReadToEnd();
                    Console.WriteLine(score);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
