using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * GameLocation.C# 
 * by Dan Firstenberg
 * 2/21/2020
 * Period 3
 */

namespace GameLocation
{
    class GameLocation
    {
        Cave theCave; // Not the actual cave used right now
        private int playerLoc = 0;
        private int wumpusLoc = 0;
        private int batOneLoc = 0;
        private int batTwoLoc = 0;
        private int pitOneLoc = 0;
        private int pitTwoLoc = 0;

        public GameLocation(Cave cave)
        {
            // Assign location to hazards and Wumpus and player
            theCave = cave;
        }

        public int movePlayer(int newRoom)
        {
            // calculate the int of the new room and return it
            // potentially move the player if the bat is in the room
            // return new location of the player after moved by bat
            return playerLoc;
        }

        public bool hasPitInRoom()
        {
            // checks if playerLoc = pitLoc 1 or 2
            return false;
        }

        public bool hasWumpusInRoom()
        {
            // checks if playerLoc = wumpusLoc
            return false;
        }

        public String hasWarning()
        {
            // runs if statements to see if playerLoc is adjacent to
            // wumpusLoc || batLoc || pitLoc
            // returns corresponding String/s
            return "";
        }

        public void moveWumpus()
        {
            // code to move wumpus 2-4 rooms away
            // need Cave object
        }

        public int getPlayerLoc()
        {
            return playerLoc;
        }

        public int getBatLoc()
        {
            // this is for the secret
            // assign each bat 0 or 1 and use a random generator to
            // see which bat location is the secret
            // assign a variable revealedBatLocation to the bat chosen
            return 0;
        }

        public int getPitLoc()
        {
            // same as getBatLoc but for pits
            return 0;
        }

        public bool shootWumpus(int roomNumber)
        {
            // return true if the player has successfully hit the wumpus
            return false;
        }

    }
}
