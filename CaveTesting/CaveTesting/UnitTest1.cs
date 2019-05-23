using System;
using System.IO;
using System.Diagnostics;
using CaveTesting;
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

        [TestMethod]
        public void Write_File_AllConnect_Test()
        {
            var caveSys = new CaveSystem();

            caveSys.WriteFile("test.txt");
        }

        [TestMethod]
        public void TestRandom()
        {
            var caveSys = new CaveSystem('r');

            caveSys.WriteFile("randCave.txt");
        }

        [TestMethod]
        public void ReadFileTest()
        {
            var caveSys = new CaveSystem("allConnected.txt");

            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine("Hello World");

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

            debug.Close();
        }
    }
}


