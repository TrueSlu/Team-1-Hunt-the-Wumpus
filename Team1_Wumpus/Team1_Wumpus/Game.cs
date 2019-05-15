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


        public Game(String n, int c)
        {

            Name = n;
            CaveNumber = c.ToString();
            PlayerManager = new Player();
            CaveManager = new CaveSystem(CaveNumber);
            TriviaManager = new Trivia();
            LocationManager = new Location();

            GameForm TheMainGameFormThing = new GameForm();
            TheMainGameFormThing.GameObject = this;

        }

        public void MakeMove()
        {

        }
    }
}
