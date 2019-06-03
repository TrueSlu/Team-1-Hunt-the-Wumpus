using System;
using System.IO;
using System.Diagnostics;
using CaveTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaveTests
{
    [TestClass]
    public class CaveTests
    {

        //caveSystem tests
        [TestMethod]
        public void Write_File_AllConnect_Test()
        {
            var caveSys = new CaveSystem();

            caveSys.WriteFile("test.txt");
        }

        [TestMethod]
        public void ReadFileTest()
        {
            var caveSys = new CaveSystem("allConnected.txt");

            //CollectionAssert.AreEqual(caveSys.GetConnectedArray(1), new int[] { 25, 26, 2, 7, 6, 30 });
            //CollectionAssert.AreEqual(caveSys.GetConnectedArray(2), new int[] { 26, 3, 9, 8, 7, 1 });
            StreamWriter debug = new StreamWriter("readInValues.txt");
            for (int i = 1; i<=30;i++)
            {
                int[] ThisArray = caveSys.GetAdjacentArray(i);
                debug.WriteLine("Cave Num: " + i.ToString() + String.Join(",", ThisArray));


                switch (i)
                {
                    case 1:
                        CollectionAssert.AreEqual(ThisArray, new int[] { 25, 26, 2, 7, 6, 30 });
                        break;
                    case 2:
                        CollectionAssert.AreEqual(ThisArray, new int[] { 26,3,9,8,7,1 });
                        break;
                    case 3:
                        CollectionAssert.AreEqual(ThisArray, new int[] { 27, 28, 4, 9, 2, 26 });
                        break;
                    default:
                        break;
                }
            }

            //removing duplicates and making connections double sided
            debug.Close();
        }

        [TestMethod]
        public void CaveSystem_system1_ReadsCorrectly()
        {
            var caveSys = new CaveSystem("system1.txt");

            for (int i = 1; i <= 30; i++)
            {
                int[] ThisArray = caveSys.GetConnectedArray(i);


                switch (i)
                {
                    case 1:
                        CollectionAssert.AreEqual(ThisArray, new int[] {0,0,2,7,0,0 });
                        break;
                    case 2:
                        CollectionAssert.AreEqual(ThisArray, new int[] {0,3,0,0,7,1});
                        break;
                    default:
                        break;
                }
            }

            //removing duplicates and making connections double sided
        }

        //cave tests
        [TestMethod]
        public void Cave_Number_Starts_Correct()
        {
            for (int caveNumber = 1; caveNumber <= 30; caveNumber++)
            {
                var cave = new Cave(caveNumber);
                Assert.AreEqual(caveNumber, cave.CaveNumber);
            }
        }

    }
}


