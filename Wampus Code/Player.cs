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

namespace Wampus_Warriors.Wampus_Code
{
    class Player
    {
        private int arrows = 0;
        private int goldCoins = 0;
        private int turns = 0;
        private int score = 0;
        private int playerX = 500;
        private int playerY = 500;

        public void setX(int x) {
            playerX = x;
        }

        public void setY(int y) {
            playerY = y;
        }

        public int getX() {
            return playerX;
        }

        public int getY() {
            return playerY;
        }
        public int numberOfArrows()
        {
            // keeps track of the number of arrows the player currently has
            return arrows;
        }

        public int numberOfGoldCoins()
        {
            // keeps track of the number of gold coins the player currently has
            return goldCoins;
        }

        public int numberOfTurns()
        {
            // keeps track of the number of turns the player has taken
            return turns;
        }

        public int finalScore()
        {
            // keeps track of the score throughout the game
            return score;
        }
    }
}
