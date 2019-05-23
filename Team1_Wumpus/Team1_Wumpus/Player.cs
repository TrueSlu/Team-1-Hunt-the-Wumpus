
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Wumpus
{
    public class Player
    {
        public int GoldCoins { get; private set; }
        public int Arrows { get; private set; }
        public int TurnsTaken { get; private set; }
        public int Score { get; private set; }
        public bool IsWumpusDead { get; set; }

        public Player()
        {
            Arrows = 3;
            GoldCoins = 10;
            TurnsTaken = 0;
            IsWumpusDead = false;

        }
        public bool ShootArrow()
        {
            if (Arrows == 0)
            {
                return false;
            }
            else
            {
                Arrows--;
                return false;
            }
        }

        public void PurchaseArrow()
        {
            bool didSpendCoin = SpendCoin(1);
            if (didSpendCoin)
            {
                Arrows++;
            }
        }

        public void TakeATurn()
        {
            TurnsTaken++;
        }

        public bool SpendCoin(int numberToSpend)
        {
            if (numberToSpend > GoldCoins)
            {
                return false;
            }
            else
            {
                GoldCoins = GoldCoins - numberToSpend;
                return true;
            }
        }

        public void CalculateScore()
        {
            int maxPoints = 100;
            int WumpusScore = 0;
            if (IsWumpusDead)
            {
                WumpusScore = 50;
            }

            Score = maxPoints - TurnsTaken + GoldCoins + (5 * Arrows) + WumpusScore;
        }

        public void SetPlayerValuesForTesting(bool isWumpusDead, int arrows, int goldCoins, int turnsTaken)
        {
            IsWumpusDead = isWumpusDead;
            Arrows = arrows;
            GoldCoins = goldCoins;
            TurnsTaken = turnsTaken;
        }
    }
}
