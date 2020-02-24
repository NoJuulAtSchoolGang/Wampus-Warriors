using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wampus_Warriors.Wampus_Code {
    class UI {

        /**
         * These are the methods used for rendering the game objects
        **/

        //will draw the player using information from the player class
        public void drawPlayer(Player player, Graphics g) {}

        //will draw the current cave using information from the GameLocation class
        public void drawCave(Cave cave, Graphics g) {}

        //public void drawWampus(boolean wampusInRoom, Graphics g) {}

        public void showHighScore(List <String> highScores, Label label){}

        //checks if the arrow is show and then whether the arrow hit anything
        //will show arrow animation
        public void drawShootArrow(Boolean ArrowShot, Boolean ArrowHit){}

        //will intilize a label that shows the controls for the game
        public void showControls(Label label){
        }

        //will get passed a panel that can change the settings of the game
        public void showSettings(Panel settingsPanel){}

    }
}
