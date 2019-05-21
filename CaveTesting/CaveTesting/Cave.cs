﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CaveTesting
{
    public class CaveSystem
    {
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
            ReadFile(fileName);
        }

        public CaveSystem() { }

        private void ReadFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string inputText = sr.ReadLine();
            while (inputText != null)
            {
                string[] strData = inputText.Split(',');
                int caveNum = int.Parse(strData[0]);
                int[] data = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    data[i] = int.Parse(strData[i + 1]);
                }

                inputText = sr.ReadLine();
                System[caveNum] = new Cave(caveNum, data);
            }
            sr.Close();
        }

        public void WriteFile(string fileName)
        {
            StreamWriter fout = new StreamWriter(fileName);

            for (int i = 1; i <= 30; i++)
            {
                string lineOutputToFile = i.ToString() + ",";
                Cave thisCave = new Cave(i);
                int[] thisCaveAdjacents = thisCave.GetAdjacentCaves();

                for (int j = 0; j < 6; j++)
                {
                    if (j == 5)
                    {
                        lineOutputToFile += thisCaveAdjacents[j];
                    }
                    else
                    {
                        lineOutputToFile += thisCaveAdjacents[j] + ",";
                    }
                }
                fout.Write(lineOutputToFile + Environment.NewLine);
            }
            fout.Close();
        }

        //private void MakeRandomSystem()
        //{
        //    int[] numConnections = new int[31];
        //    Random r = new Random();
        //    for(int i=1; i<31; i++)
        //    {
        //        numConnections[i] = r.Next(1, 3 + 1);
        //    }

        //    int randomCaveDirection;
        //    for (int i = 1; i < 31; i++)
        //    {
        //        //makes list with the numbers of the directions the connections will be made
        //        List<int> connectedCaveDirections = new List<int>();
        //        for (int connectedCavesMade=1; connectedCavesMade<=numConnections[i];connectedCavesMade++)
        //        {
        //            randomCaveDirection = r.Next(1, 7);
        //            if (connectedCaveDirections.Contains(randomCaveDirection))
        //            {
        //                connectedCavesMade--;
        //            }
        //            else
        //            {
        //                connectedCaveDirections.Add(randomCaveDirection);
        //            }
        //        }
        //        connectedCaveDirections.Sort();
        //        numConnections[i] = r.Next(1, 3 + 1);
        //    }
        //}

        //methods for other classes

        public int[] GetAdjacentArray(int caveNumber)
        {
            //returns list with the adjacent caves
            return System[caveNumber].GetAdjacentCaves();
        }

        public int[] GetConnectedArray(int caveNumber)
        {
            return System[caveNumber].GetConnectedCaves();
        }

        public List<int> GetConnectedList(int caveNumber)
        {
            int[] unfCaves = System[caveNumber].GetConnectedCaves();
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
            }
        }

        public Cave() { }

        public int FormatCaveNumber(int toFormat)
        {
            //return toFormat % 30;
            int corrected = toFormat % 30;

            // microsoft land has modulus less than zero???
            // https://en.wikipedia.org/wiki/Modulo_operation has range from 0 to n-1, as it should be

            if (corrected<=0)
            {
                corrected += 30;
                return corrected;
            }
            else
            {
                return corrected;
            }
        }

        public int[] GetAdjacentCaves()
        {
            CalculateAdjacentCaves();
            return AdjacentCaves;
        }

        public int[] GetConnectedCaves()
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
                northEastCave = CaveNumber - 1;
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
    }
}
