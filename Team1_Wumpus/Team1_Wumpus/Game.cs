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
        public TriviaManager TriviaObject { get; set; }
        public Location LocationManager { get; set; }
        public Sound SoundManager { get; set; }
        public HighScoreManager HighScoreTracker { get; set; }
        public GameForm GameUI { get; private set; }

        public Game(String n, String c, bool t, int caveID)
        {

            Name = n;
            CaveNumber = caveID.ToString();
            PlayerManager = new Player();
            CaveManager = new CaveSystem(c);
            TriviaObject = new TriviaManager();
            HighScoreTracker = new HighScoreManager();
            LocationManager = new Location();
            LocationManager.Cave = CaveManager;
            SoundManager = new Sound();


            GameUI = new GameForm();
            GameUI.GameObject = this;
            LocationManager.InitializePosition();
            SoundManager.PlayBackground();
            GameUI.TestMode = t;
            GameUI.ShowDialog();
        }

        public string MovePlayer(int desiredCave)
        {
            LocationManager.PlayerMovement(desiredCave);
            PlayerManager.TakeATurn();

            string PositionStatus = LocationManager.CheckPositions();
            if (PositionStatus == "wumpus")
            {
                SoundManager.PlayWumpus();
                bool didWin = TriviaObject.TriviaBattle(5, 3);
                if (didWin)
                {
                    LocationManager.WumpusMoves();
                } else
                {
                    EndGameNormally();
                }
            } else if (PositionStatus == "pit")
            {
                //trivia
                //sound
                SoundManager.PlayPit();
                bool didWin = TriviaObject.TriviaBattle(3, 1);
                if (didWin)
                {
                    LocationManager.WumpusMoves();
                }
                else
                {
                    EndGameNormally();
                }
                LocationManager.PitsMove();
            } else if (PositionStatus == "bat")
            {
                //trivia
                //sound
                SoundManager.PlayBats();
                LocationManager.BatsMove();
                LocationManager.BatFling();
                return "A bat flung you to another room!";
            }

            string Proximity = LocationManager.CheckProximity(CaveManager.GetConnectedList(LocationManager.Player));
            if (Proximity == "wumpus")
            {
                return "The Wumpus is close.";
            } else if (Proximity == "pit")
            {
                return "I feel a draft.";
            } else if (Proximity == "bat")
            {
                return "Bats are squeaky.";
            } else
            {
                return TriviaObject.GetSecret();
            }

            //get a secret thing and show it
        }

        public bool FireArrow(int desiredCave)
        {
            bool didShootArrow = PlayerManager.ShootArrow();
            if (didShootArrow)
            {
                PlayerManager.TakeATurn();
                if (desiredCave == LocationManager.Wumpus)
                {
                    PlayerManager.IsWumpusDead = true;
                    EndGameNormally();
                }
            }

            return didShootArrow;
            //get a secret thing and show it


        }


        public void EndGameNormally()
        {
            GameUI.Close();
            PlayerManager.CalculateScore();
            HighScore newHighScore = new HighScore(Name, CaveNumber, PlayerManager.Score);
            HighScoreTracker.WriteNewScore(newHighScore);

            GameEndForm CreditsForm = new GameEndForm();
            CreditsForm.PlayerObject = PlayerManager;
            CreditsForm.PlayerName = Name;
            CreditsForm.ShowDialog();
        }
    }
}