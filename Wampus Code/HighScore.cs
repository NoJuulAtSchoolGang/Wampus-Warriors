using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wampus_Warriors.Wampus_Code {
    class HighScore {

        //constants for file locations
        private static String SAVE_FILE_LOCATION;
        private static String NEW_SCORE_LOCATION;
        private static String BACKUP_SCORE_LOCATION;

        //list that contains data for users
        private static List<User> users;

        //constructor
        public HighScore() {
            users = new List<User>();
        }

        //method to return current high scores as a string
        public String [] getHighScores() {
            String[] array = new string[5];
            return array;
        }

        //method to add high score
        public void addHighScore(int score) {

        }


    }
}
