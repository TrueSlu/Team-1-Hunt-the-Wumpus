using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Team1_Wumpus
{
    public class CaveSystem
    {
        string SEP_CHAR = "\t";

        //format of the lists returned are 
        //six integer list
        //position 0 is cave directly north
        //position 1 is cave northeast
        //position 2 is cave southeast
        //position 3 is cave south
        //position 4 is cave southwest
        //position 5 is cave northwest

        public Cave[] System = new Cave[31]; // System[0] is unused

        public CaveSystem(string fileName)
        {
            for (int i = 1; i <= 30; i++)
            {
                System[i] = new Cave();
            }
            ReadFile(fileName);
        }

        public CaveSystem(char mode)
        {
            for (int i = 1; i <= 30; i++)
            {
                System[i] = new Cave();
            }

            if (mode == 'r')
            {
                MakeRandomSystem();
            }
        }

        //test mode, defaults to all connected
        public CaveSystem()
        {
            for (int i = 1; i <= 30; i++)
            {
                System[i] = new Cave(i);
                System[i].MakeAllConnected();
            }
        }

        private void ReadFile(string fileContents)
        {
            string[] fileArray = fileContents.Split('\n');
            int index = 0;
            while (index < fileArray.Length)
            {
                string[] strData = fileArray[index].Split(SEP_CHAR.ToCharArray()[0]);
                int caveNum = int.Parse(strData[0]);
                int[] data = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    data[i] = int.Parse(strData[i + 1]);
                }

                index++;
                System[caveNum] = new Cave(caveNum, data);
            }
        }

        public void WriteFile(string fileName)
        {
            StreamWriter fout = new StreamWriter(fileName);

            for (int i = 1; i <= 30; i++)
            {
                string lineOutputToFile = i.ToString() + SEP_CHAR;
                Cave thisCave = new Cave(i);
                int[] thisCaveAdjacents = thisCave.GetConnectedArray();

                lineOutputToFile +=
                    String.Join(SEP_CHAR, System[i].GetConnectedArray());


                fout.Write(lineOutputToFile + Environment.NewLine);
            }
            fout.Close();
        }

        //makes the random directions used in MakeRandomSystem
        private int[,] MakeRandomDirections()
        {
            StreamWriter infoOut = new StreamWriter("MakeRandomDirectionsOut.txt");

            Random r = new Random();
            int[] numConnections = new int[31];
            int[,] toReturn = new int[31, 6];
            for (int i = 1; i <= 30; i++)
            {
                numConnections[i] = r.Next(1, 4);
            }

            infoOut.Close();

            return toReturn;
        }
        public void MakeRandomSystem()  //does not work
        {
            Random r = new Random();
            int[] numConnections = new int[31];         // stores number of connections randomly made
            for (int i = 1; i <= 30; i++)
            {
                numConnections[i] = 0;
            }
            StreamWriter infoOut = new StreamWriter("values.txt");  //debug information

            //making one connection for each room, as required
            for (int caveNum = 1; caveNum <= 30; caveNum++)
            {
                Cave ThisCave = System[caveNum];
                int connectionDirection = r.Next(0, 6); //random direction to make
                int randomCaveNumber = System[caveNum].GetAdjacentArray()[connectionDirection];
                if (!IsConnected(caveNum, randomCaveNumber))  // checks if connection not already made
                {
                    infoOut.WriteLine("made connection betw." + caveNum.ToString());
                    numConnections[caveNum]++;
                    numConnections[randomCaveNumber]++;
                    System[caveNum].MakeConnection(randomCaveNumber); //makes connection FROM caveNum to the random
                }

                infoOut.WriteLine("CAVENUM: " + caveNum.ToString() + "\t" +
                    "DIRECTION:" + connectionDirection.ToString() + "\n" +
                    "DIRECTION CAVE NUMBER: " + randomCaveNumber.ToString() + "\n" +
                    String.Join("\t", System[caveNum].GetConnectedArray()) + "\n");
            }

            infoOut.Close();
        }

        private void DEPMakeRandomSystem() //old code, does not make correct number of connections
        {
            Random r = new Random();

            int[] numConnections = new int[31];
            int[] currentConnections = new int[31];
            //assigns the number of connections each cave will have
            for (int i = 1; i < 31; i++)
            {
                numConnections[i] = r.Next(1, 3 + 1);
                currentConnections[i] = 0;
            }

            StreamWriter debug = new StreamWriter("values.txt");

            int randomCaveDirection;
            for (int caveNum = 1; caveNum < 31; caveNum++)
            {
                // makes list with the numbers of the directions 
                // the connections will be made
                List<int> connectedCaveDirections = new List<int>();
                for (int connectedCavesMade = 1;
                    connectedCavesMade <= numConnections[caveNum]; connectedCavesMade++)
                {
                    randomCaveDirection = r.Next(0, 6);
                    if (connectedCaveDirections.Contains(randomCaveDirection))
                    {
                        connectedCavesMade--;
                    }
                    else
                    {
                        connectedCaveDirections.Add(randomCaveDirection);
                    }
                }
                connectedCaveDirections.Sort();

                // debug file for caveDirs
                numConnections[caveNum] = r.Next(1, 3 + 1);

                System[caveNum] = new Cave(caveNum, connectedCaveDirections);


                debug.WriteLine("CAVENUM: " + caveNum.ToString() + "\t" +
                    "CONNECTIONS: " + numConnections[caveNum] +
                    "\tDIRECTIONS:" + string.Join(",", connectedCaveDirections) + "\n" +
                    String.Join("\t", System[caveNum].GetConnectedArray()) + "\n");

                //

            }

            //making connections double-sided
            for (int caveNum = 1; caveNum < 31; caveNum++)
            {

                for (int caveDir = 0; caveDir < 6; caveDir++)
                {
                    int connectedCave = System[caveNum].GetConnectedArray()[caveDir];
                    if (connectedCave != 0)
                    {
                        System[connectedCave].MakeConnection(caveNum);
                    }
                }

            }

            //removing excess connections
            for (int caveNum = 1; caveNum < 31; caveNum++)
            {
                while (System[caveNum].NumberConnections() > 3)
                {
                    bool ConnectionHasBeenRemoved = false;
                    while (!ConnectionHasBeenRemoved)
                    {
                        int randomDirection = r.Next(0, 6);
                        int randomDirectionCaveNum =
                            System[caveNum].GetConnectedArray()[randomDirection];
                        if (randomDirectionCaveNum != 0
                             && System[randomDirectionCaveNum].NumberConnections() - 1 >= 1)
                        {
                            System[caveNum].RemoveConnection(randomDirection);
                            //removing from other side
                            System[randomDirectionCaveNum]
                                .RemoveConnection((randomDirection + 3) % 6);
                            ConnectionHasBeenRemoved = true;
                        }

                    }
                }
            }
            debug.Close();

        }

        //methods for other classes

        public int[] GetAdjacentArray(int caveNumber)
        {
            //returns list with the adjacent caves
            return System[caveNumber].GetAdjacentArray();
        }

        public int[] GetConnectedArray(int caveNumber)
        {
            return System[caveNumber].GetConnectedArray();
        }

        public List<int> GetConnectedList(int caveNumber)
        {
            int[] unfCaves = System[caveNumber].GetConnectedArray();
            List<int> connectedCaves = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                if (unfCaves[i] >= 1)
                {
                    connectedCaves.Add(unfCaves[i]);
                }
            }
            return connectedCaves;
        }

        public bool IsConnected(int caveNum1, int caveNum2)
        {
            foreach (int connectedCaveNum in System[caveNum1].GetConnectedArray())
            {
                if (connectedCaveNum == caveNum2)
                {
                    return true;
                }
            }
            return false;
        }
    }


    public class Cave
    {
        public int CaveNumber { get; private set; }
        private int[] AdjacentCaves { get; set; } = new int[6];      //not very useful
        private int[] ConnectedCaves { get; set; } = new int[6];

        //public Cave(int c, int[] ac, int[] cc)
        //{
        //    if (ac.Length != 6 || cc.Length != 6)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        CaveNumber = c;
        //        AdjacentCaves = ac;
        //        ConnectedCaves = cc;
        //    }
        //}

        public Cave(int c, int[] cc)
        {
            if (cc.Length != 6)
            {
                return;
            }
            else
            {
                CaveNumber = c;
                ConnectedCaves = cc;
                CalculateAdjacentCaves();
            }

        }

        public Cave(int c)
        {
            if (c != FormatCaveNumber(c))
            {
                return;
            }
            else
            {
                CaveNumber = c;
                CalculateAdjacentCaves();
            }
        }

        public Cave(int c, List<int> dirs)
        {
            CaveNumber = c;
            CalculateAdjacentCaves();
            ConnectedCaves = new int[] { 0, 0, 0, 0, 0, 0 };
            foreach (int direction in dirs)
            {
                ConnectedCaves[direction] = AdjacentCaves[direction];
            }
        }
        public Cave() { }

        public void MakeAllConnected()
        {
            ConnectedCaves = AdjacentCaves;
        }
        public void MakeConnection(int caveNum)
        {
            for (int direction = 0; direction < 6; direction++)
            {
                if (AdjacentCaves[direction] == caveNum)
                {
                    ConnectedCaves[direction] = caveNum;
                }
            }
        }

        public void RemoveConnection(int caveNum)
        {
            for (int direction = 0; direction < 6; direction++)
            {
                if (AdjacentCaves[direction] == caveNum)
                {
                    ConnectedCaves[direction] = 0;
                }
            }
        }
        public int FormatCaveNumber(int toFormat)
        {
            //return toFormat % 30;
            int corrected = toFormat % 30;

            // microsoft land has modulus less than zero???
            // https://en.wikipedia.org/wiki/Modulo_operation
            // has range from 0 to n-1, as it should be

            if (corrected <= 0)
            {
                corrected += 30;
                return corrected;
            }
            else
            {
                return corrected;
            }
        }

        public int[] GetAdjacentArray()
        {
            CalculateAdjacentCaves();
            return AdjacentCaves;
        }

        public int[] GetConnectedArray()
        {
            return ConnectedCaves;
        }

        public void CalculateAdjacentCaves()
        {
            // north cave
            int northCave = CaveNumber - 6;
            northCave = FormatCaveNumber(northCave);

            // northeast cave
            int northEastCave;
            if (CaveNumber % 2 == 0 && CaveNumber % 6 != 0)
            {
                northEastCave = CaveNumber + 1;
            }
            else //if (CaveNumber % 2 == 1 || CaveNumber % 6 == 0)
            {
                northEastCave = CaveNumber - 5;
            }
            northEastCave = FormatCaveNumber(northEastCave);

            //southeast cave
            int southEastCave;
            if (CaveNumber % 2 == 1 || CaveNumber % 6 == 0)
            {
                southEastCave = CaveNumber + 1;
            }
            else// if (CaveNumber % 2 == 0)
            {
                southEastCave = CaveNumber + 7;
            }
            southEastCave = FormatCaveNumber(southEastCave);

            //south cave
            int southCave = CaveNumber + 6;
            southCave = FormatCaveNumber(southCave);

            //southwest cave
            int southWestCave;
            if (CaveNumber % 6 == 1 || CaveNumber % 2 == 0)
            {
                southWestCave = CaveNumber + 5;
            }
            else// if (CaveNumber % 2 == 0)
            {
                southWestCave = CaveNumber - 1;
            }
            southWestCave = FormatCaveNumber(southWestCave);

            //northwest cave
            int northWestCave;
            if (CaveNumber % 2 == 0 || CaveNumber % 6 == 1)
            {
                northWestCave = CaveNumber - 1;
            }
            else
            {
                northWestCave = CaveNumber - 7;
            }
            northWestCave = FormatCaveNumber(northWestCave);
            AdjacentCaves = new int[] { northCave, northEastCave, southEastCave, southCave,
                                southWestCave, northWestCave};


        }

        public int NumberConnections()
        {
            int i = 0;
            foreach (int connCaveNum in ConnectedCaves)
            {
                if (connCaveNum != 0)
                {
                    i++;
                }
            }
            return i;
        }
    }
}
