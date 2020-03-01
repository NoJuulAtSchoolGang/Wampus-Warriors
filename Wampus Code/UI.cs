using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Wampus_Warriors.Wampus_Code {
    class UI {

        private Image playerUp;
        private Image playerDown;
        private Image playerLeft;
        private Image playerRight;
        private Size STANDARD_SIZE = Wampus_Warriors.STANDARD_SIZE;
        private double conversionFactor;

        public UI(double conversionFactor) {

            this.conversionFactor = conversionFactor;
            try {
                playerUp = Image.FromFile(Path.Combine(Wampus_Warriors.DIR_LOCATION, "Images\\playerUp.png"));
                playerDown = Image.FromFile(Path.Combine(Wampus_Warriors.DIR_LOCATION, "Images\\playerDown.png"));
                playerLeft = Image.FromFile(Path.Combine(Wampus_Warriors.DIR_LOCATION, "Images\\playerLeft.png"));
                playerRight = Image.FromFile(Path.Combine(Wampus_Warriors.DIR_LOCATION, "Images\\playerRight.png")); 
            }
            catch(Exception e) {
                Console.WriteLine(e.StackTrace);

            }
            

            
            
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
            else if (direction.Equals("down")) {
                playerImage = playerDown;
            }
            else if (direction.Equals("left")) {
                playerImage = playerLeft;
            }
            else {
                playerImage = playerRight;
            }

            Rectangle playerRect = new Rectangle(x, y, (int)(playerImage.Width/20 * conversionFactor), (int)(playerImage.Height/5 * conversionFactor));
            g.DrawImage(playerImage, playerRect);
        }

        //will draw the current cave using information from the GameLocation class
        public void drawCave(GameLocation location, Graphics g) {
            

        }

        public void drawWampus(bool wampusInRoom, Graphics g) {}
        
        public void showHighScore(List <String> highScores, Label label, Size ContainerSize){
            Console.WriteLine(STANDARD_SIZE.Width * conversionFactor + " " + STANDARD_SIZE.Height * conversionFactor);
            label.Size = new Size((int)(STANDARD_SIZE.Width/2 * conversionFactor), (int)(STANDARD_SIZE.Height/1.2 * conversionFactor));
            Console.WriteLine(label.Size);
            int x = (ContainerSize.Width/2) - label.Size.Width/2;
            int y = (ContainerSize.Height/2) - label.Size.Height/2;

            label.Location = new Point(x, y);
            float emSize = 14 * (float)conversionFactor;

            label.Font = new Font(label.Font.FontFamily, emSize);

            
            String str = "High Scores\n\n";
            foreach(String highScore in highScores) {
                str += (highScores.IndexOf(highScore) + 1) + ". " + highScore + "\n\n";
            }

            label.Text = str;
            
            
            label.Visible = true;

        }

        //passed if the arrow is show and then whether the arrow hit anything
        //will show arrow animation
        public void drawShootArrow(Boolean ArrowShot, Boolean ArrowHit, Graphics g){}

        //will intilize a label that shows the controls for the game
        public void showControls(Label label){
        }

        //hints about surroundings
        public void showHints(String hints, Label lbl) {

        }

        public void updateConversionFactor(double conversionFactor) {
            this.conversionFactor = conversionFactor;
        }

    }
}
