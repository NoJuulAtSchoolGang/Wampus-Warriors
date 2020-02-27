using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Wampus_Warriors.Wampus_Code {
    class UI {

        private Image playerUp;
        private Image playerDown;
        private Image playerLeft;
        private Image playerRight;
        private Size canvas_size;

        public UI(Size canvas_size) {
            playerUp = Image.FromFile("playerUp.jpg");
            playerDown = Image.FromFile("playerDown.jpg");
            playerLeft = Image.FromFile("playerLeft.jpg");
            playerRight = Image.FromFile("playerRight.jpg");

            this.canvas_size = canvas_size;
        }
        /**
         * These are the methods used for rendering the game objects
        **/

        //will draw the player using information from the player class
        public void drawPlayer(Player player, String direction, Graphics g) {
            int x = player.getX();
            int y = player.getY();

            Image playerImage;
            if (direction.Equals("up")){
                playerImage = playerUp;
            }
            if (direction.Equals("down")) {
                playerImage = playerDown;
            }
            if (direction.Equals("left")) {
                playerImage = playerLeft;
            }
            if (direction.Equals("right")) {
                playerImage = playerRight;
            }

            Rectangle playerRect = new Rectangle(x, y, this.canvas_size.Width/20, this.canvas_size.Width/20);

            g.DrawImage(playerImage, playerRect);
        }

        //will draw the current cave using information from the GameLocation class
        public void drawCave(GameLocation location, Graphics g) {
            

        }

        public void drawWampus(bool wampusInRoom, Graphics g) {}

        public void showHighScore(List <String> highScores, Label label){}

        //passed if the arrow is show and then whether the arrow hit anything
        //will show arrow animation
        public void drawShootArrow(Boolean ArrowShot, Boolean ArrowHit, Graphics g){}

        //will intilize a label that shows the controls for the game
        public void showControls(Label label){
        }

        //will get passed a panel that can change the settings of the game
        public void showSettings(Panel settingsPanel){}

        //hints about surroundings
        public void showHints(String hints) {

        }

    }
}
