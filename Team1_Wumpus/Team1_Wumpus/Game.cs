using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class Game
    {

        public String CaveNumber { get; set; }
        public String Name { get; set; }
        public Player PlayerManager { get; private set; }
        public CaveSystem CaveManager { get; set; }
        public Trivia TriviaManager { get; set; }
        public Location LocationManager { get; set; }
        public Sound SoundManager { get; set; }
        public HighScoreManager HighScoreTracker { get; set; }

        public Game(String n, String c)
        {

            Name = n;
            CaveNumber = c.ToString();
            PlayerManager = new Player();
            CaveManager = new CaveSystem(CaveNumber);
            //TriviaManager = new TriviaManager();
            HighScoreTracker = new HighScoreManager();
            LocationManager = new Location();
            SoundManager = new Sound();


            GameForm GameUI = new GameForm();
            GameUI.GameObject = this;
            GameUI.ShowDialog();
        }

        public void InitializeGame()
        {
            LocationManager.InitializePosition();
        }

        public void MakeMove()
        {

        }



        public void EndGameNormally()
        {
            PlayerManager.CalculateScore();
            HighScore newHighScore = new HighScore(Name, CaveNumber, PlayerManager.Score);
            HighScoreTracker.AddNewHighScore(newHighScore);


        }


    }
}
