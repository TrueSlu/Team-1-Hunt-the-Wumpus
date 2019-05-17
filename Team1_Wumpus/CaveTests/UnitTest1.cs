using System;
using Team1_Wumpus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaveTests
{
    [TestClass]
    public class CaveConstructorTests
    {
        [TestMethod]
        public void Cave_Number_Starts_Correct()
        {
            var cave = new Cave(1);
            Assert.AreEqual(1, cave.CaveNumber);
        }
    }

    [TestClass]
    public class CaveMethodTests
    {
        [TestMethod]
        public void TestAllConnections()
        {
            var caveSys = new CaveSystem();

            caveSys.WriteFile("allConnected");
        }
    }
}

namespace CaveSystemTests
{
    [TestClass]
    public class CaveConstructorTests
    {
        [TestMethod]
        public void Cave_Number_Starts_Correct()
        {
        }
    }

    [TestClass]
    public class CaveMethodTests
    {

    }
}
