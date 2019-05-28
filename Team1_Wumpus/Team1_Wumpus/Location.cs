using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class Location
    {
        public List<int> Bats { get; set; }
        public List<int> Pits { get; set; }
        public int Player { get; set; }
        public int Wumpus { get; set; }
        public CaveSystem Cave { get; set; }
        public int Cavenumber { get; set; }
        public List<int> ConnectedCaves { get; set; }
     
        //method that initializes locations of objects
        public void InitializePosition()
        {
            //1 is the smallest room number and 31 is the largest
            Random r = new Random();
            int bat1;
            int bat2;
            int pit1;
            int pit2;
            bat1 = r.Next(1, 31);
            bat2 = r.Next(1, 31);
            pit1 = r.Next(1, 31);
            pit2 = r.Next(1, 31);
            Wumpus = r.Next(1, 31);
            Player = r.Next(1, 31);
            if(bat1 == bat2||bat1==pit1||bat1==pit2 || bat1 ==Wumpus || bat1 ==Player)
            {
                bat1 = r.Next(1, 31);
            }
            else if(bat2==pit1||bat2==pit2||bat2==Wumpus||bat2==Player)
            {
                bat2 = r.Next(1, 31);
            }
            else if(pit1==pit2||pit1==Wumpus||pit1==Player)
            {
                pit1 = r.Next(1, 31);
            }
            else if(pit2==Wumpus||pit2==Player)
            {
                pit2 = r.Next(1, 31);
            }
            else if(Wumpus==Player)
            {
                Wumpus = r.Next(1, 31);
            }
            Bats[0] = bat1;
            Bats[1] = bat2;
            Pits[0] = pit1;
            Pits[1] = pit2;
        }
        //method that moves objects (ability to move, no need to implement logic from spec)... i.e. if player moves triggers wumpus move, 
        //just have a method for player move and one for wumpus move
        public void BatsMove()
        {
            Random r = new Random();
            for (int i = 0; i < Bats.Count; i++)
            {
                if(Bats[i] == Player)
                {
                    int newPlayerPosition = r.Next(1, 31);
                    if (Player != newPlayerPosition)
                    {
                        Player = newPlayerPosition;
                    }

                    Bats[i] = r.Next(1, 31);
                    break;
                }
            }
        }

        public void PitsMove()
        {
            Random r = new Random();
            for (int i = 0; i < Pits.Count; i++)
            {
                if(Pits[i] == Player)
                {
                    int newPlayerPosition = r.Next(1, 31);
                    if (Player != newPlayerPosition)
                    {
                        Player = newPlayerPosition;
                    }

                    Pits[i] = r.Next(1, 31);
                    break;

                }

            }
        }

        public void WumpusMoves()
        {
            int numberofmoves;
            if(Wumpus == Player)
            {
                Random r = new Random();
                numberofmoves = r.Next(1, 5);
                for (int i = 0; i < numberofmoves; i++)
                {
                    int randomCave = r.Next(0, Cave.GetConnectedList(Cavenumber).Count);
                    Cave.GetConnectedList(Cavenumber);
                    WumpusMovement(Cavenumber);
                }
                
            }
            for (int i = 0; i < Pits.Count; i++)
            {
                if(Wumpus == i)
                {
                    Random r = new Random();
                    Pits[i] = r.Next(1,31);
                }
                    
            }
            for(int i = 0; i<Bats.Count; i++)
            {
                if(Wumpus == i)
                {
                    Random r = new Random();
                    Bats[i] = r.Next(1, 31);
                }
            }
        }
        public void WumpusMovement(int cavenumber)
        {
            Wumpus = cavenumber;
        }

        public void PlayerMovement(int desiredcave)
        {
            //if wanted cave's number is avaliable then allow movement to that cave
            int checkForMovement = 0;
            foreach (int availableCave in ConnectedCaves)
            {
                if (desiredcave == availableCave)
                {
                    //allow movement to the cave
                    Player = desiredcave;
                    checkForMovement++;
                }
           
            }

            if (checkForMovement < 1)
            {
                return;
            }

            ConnectedCaves = Cave.GetConnectedList(Cavenumber);
        }

        
        //method that returns locations of obstacles/player
    }
}
