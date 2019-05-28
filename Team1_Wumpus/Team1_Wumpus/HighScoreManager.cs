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

        public void CreateSampleScore()
        {
            Random rnd = new Random();
            int score = rnd.Next(1, 13);  // creates a number between 1 and 12

            HighScore TestScore = new HighScore("TestScore", "I am a test score", score);
            WriteNewScore(TestScore);
        }

        public double GetScore(int index)
        {
            return scores[index].Score;
        }

        private string ManipulateScoreObject(HighScore Score)
        {
            string HighScoreString;

            HighScoreString = Score.Name.ToString() + "," + Score.Cave.ToString() + "," + Score.Score.ToString();

            return HighScoreString;
        }

        public void WriteNewScore(HighScore Score)
        {
            string WritableScore = ManipulateScoreObject(Score);
            
            string FetchScores =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter("WumpusHighScores.txt", append: true))
            {
                outputFile.WriteLine(WritableScore);
            }

        }

        private HighScore ParseCSVHighScore(string ScoreString)
        {
            IList<string> scoreArray = ScoreString.Split(',').ToList<string>();
            HighScore HighScoreObject = new HighScore(scoreArray[0], scoreArray[1], int.Parse(scoreArray[2]));
            return HighScoreObject;
        }

        private List<string> SplitLinesCSVHelper(string FileText)
        {
            List<string> ScoreLines = FileText.Split('\n').ToList<string>();
            return ScoreLines;
        }

        public List<HighScore> ReadScores()
        {
            List<HighScore> ExtractedScores = new List<HighScore>();
            try
            {   
                using (StreamReader sr = new StreamReader("WumpusHighScores.txt"))
                {
                    String ScoreFileText = sr.ReadToEnd();
                    List<string> ScoresList = SplitLinesCSVHelper(ScoreFileText);
                    foreach(string score in ScoresList)
                    {
                        if (score == "")
                        {
                            continue;
                        }
                        HighScore scoreObject = ParseCSVHighScore(score);
                        ExtractedScores.Add(scoreObject);
                    }

                }

                return ExtractedScores;
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
