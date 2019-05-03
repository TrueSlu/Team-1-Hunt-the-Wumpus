using System;
using Team1_Wumpus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WumpusTests
{
    [TestClass]
    public class PlayerConstructorTests
    {
        [TestMethod]
        public void Player_Arrows_StartsWith3()
        {
            var player = new Player();
            Assert.AreEqual(3, player.Arrows);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Player_GoldCoins_StartsWith0()
        {
            var player = new Player();
            Assert.AreEqual(10, player.GoldCoins);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Player_TurnsTaken_StartsWith0()
        {
            var player = new Player();
            Assert.AreEqual(0, player.TurnsTaken);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void Player_IsWumpusDead_StartsWithFalse()
        {
            var player = new Player();
            Assert.AreEqual(false, player.IsWumpusDead);
        }
    }

    [TestClass]

    public class PlayerMethodTests
    {
        [TestMethod]
        public void Player_TakeATurn_Increments_Player_TurnsTaken_By_1()
        {
            var player = new Player();
            int expectedTurns = player.TurnsTaken + 1;
            player.TakeATurn();
            Assert.AreEqual(expectedTurns, player.TurnsTaken);
        }

        [TestMethod]
        public void Player_ShootArrow_Decrements_Player_Arrows_By_1()
        {
            var player = new Player();
            int expectedArrows = player.Arrows - 3;
            player.ShootArrow();
            player.ShootArrow();
            player.ShootArrow();
            bool didShootFourthArrow = player.ShootArrow();
            Assert.AreEqual(didShootFourthArrow, false);
            Assert.AreEqual(expectedArrows, player.Arrows);
        }

        [TestMethod]
        public void Player_BuyArrow_Increments_Player_Arrows_By_1_And_Decrements_Player_GoldCoins_By_1()
        {
            var player = new Player();
            int expectedArrows = player.Arrows + 1;
            int expectedCoins = player.GoldCoins - 1;
            player.PurchaseArrow();
            Assert.AreEqual(expectedArrows, player.Arrows);
            Assert.AreEqual(expectedCoins, player.GoldCoins);
        }

        [TestMethod]
        public void Player_SpendCoin_Decrements_Player_GoldCoins_By_numberToSpend()
        {
            var player = new Player();
            int expectedCoins = player.GoldCoins;

            int coinsToSpend = 4;
            bool didSpendCoins = player.SpendCoin(coinsToSpend);
            Assert.AreEqual(false, didSpendCoins);
            Assert.AreEqual(expectedCoins, player.GoldCoins);

            coinsToSpend = 2;
            expectedCoins = expectedCoins - 2;
            didSpendCoins = player.SpendCoin(coinsToSpend);
            Assert.AreEqual(true, didSpendCoins);
            Assert.AreEqual(expectedCoins, player.GoldCoins);
        }

        [TestMethod]
        public void Player_Test_Score_Calculation()
        {
            var player = new Player();
            const int MAX_POINTS = 100;
            bool isWumpusDead = true;
            int arrows = 20;
            int goldCoins = 13;
            int turnsTaken = 47;
            int wumpusScore = 0;
            if (isWumpusDead)
            {
                wumpusScore = 50;
            }

            int expectedScore = MAX_POINTS - turnsTaken + goldCoins + (5 * arrows) + wumpusScore;

            player.SetPlayerValuesForTesting(isWumpusDead, arrows, goldCoins, turnsTaken);
            player.CalculateScore();
            Assert.AreEqual(expectedScore, player.Score);
        }
    }
}