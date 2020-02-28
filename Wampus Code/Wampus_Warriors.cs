using System;
using System.Drawing;
using System.Windows.Forms;
using Wampus_Warriors.Wampus_Code;

namespace Wampus_Warriors {
    public partial class Wampus_Warriors : Form {

        private bool playGame = false;
        private double scaleFactor = 1;
        private readonly Size STANDARD_SIZE = new Size(640, 480);

        //this is the constructor
        public Wampus_Warriors() {
            InitializeComponent();
            startScreenSetUp();
        }

        //method to return the preferred size of the game canvas
        private Size getSize() {
            double conversion_factor;
            if (ClientSize.Width / (double)STANDARD_SIZE.Width <= ClientSize.Height / (double)STANDARD_SIZE.Height) {
                conversion_factor = (ClientSize.Width / (double)STANDARD_SIZE.Width);
            }
            else {
                conversion_factor = (ClientSize.Height / (double)STANDARD_SIZE.Height);
            }


            this.scaleFactor = conversion_factor;

            return new Size((int)(STANDARD_SIZE.Width * conversion_factor),(int)(STANDARD_SIZE.Height * conversion_factor));

        }
        //sets up the the start screen buttons relative to the screen size
        public void startScreenSetUp() {
            //sets the size of the game canvas to the size of the form that the game is on
            Game_Canvas.Size = getSize();

            //sets Game canvas to center of the screen
            int x = (this.ClientSize.Width - Game_Canvas.Width) / 2;
            int y = (this.ClientSize.Height - Game_Canvas.Height) / 2;

            Game_Canvas.Location = new Point(x, y);

            //dictates the size of the buttons
            Size ButtonLocation = new Size(Game_Canvas.Width / 8, Game_Canvas.Height / 5);

            //sets buttons to same size
            StartBtn.Size = ButtonLocation;
            HighScoreBtn.Size = ButtonLocation;
            SettingsBtn.Size = ButtonLocation;
            ExitBtn.Size = ButtonLocation;

            //sets the location of the buttons relative to each other
            StartBtn.Location = new Point((int)(Game_Canvas.Location.X + Game_Canvas.Width * 0.25 - ButtonLocation.Width/2), (int)(Game_Canvas.Location.Y + Game_Canvas.Height * 0.25 - ButtonLocation.Height/2));
            HighScoreBtn.Location = new Point((int)(Game_Canvas.Location.X + Game_Canvas.Width * 0.75 - ButtonLocation.Width/2), (int)(Game_Canvas.Location.Y + Game_Canvas.Height * 0.25 - ButtonLocation.Height/2));
            SettingsBtn.Location = new Point((int)(Game_Canvas.Location.X + Game_Canvas.ClientSize.Width * 0.25 - ButtonLocation.Width / 2), (int)(Game_Canvas.Location.Y + Game_Canvas.Height * 0.75 - ButtonLocation.Height / 2));
            ExitBtn.Location = new Point((int)(Game_Canvas.Location.X + Game_Canvas.ClientSize.Width * 0.75 - ButtonLocation.Width / 2), (int)(Game_Canvas.Location.Y + Game_Canvas.Height * 0.75 - ButtonLocation.Height / 2));
        }

        //method to start the game
        //triggered when start button is pressed
        private void StartGame() {
            //disables and makes all the buttons invisible
            StartBtn.Visible = false;
            StartBtn.Enabled = false;

            ExitBtn.Visible = false;
            ExitBtn.Enabled = false;

            SettingsBtn.Visible = false;
            SettingsBtn.Enabled = false;

            HighScoreBtn.Visible = false;
            HighScoreBtn.Enabled = false;

            //allows the form to take user input
            this.Focus();

            //initilizes the frame rate of the game
            GameTimer.Interval = 100;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();

            //bool to indicate game is being played
            playGame = true;
            
        }

        private void endGame() {
            GameTimer.Stop();
            playGame = false;

            StartBtn.Visible = true;
            StartBtn.Enabled = true;

            ExitBtn.Visible = true;
            ExitBtn.Enabled = true;

            SettingsBtn.Visible = true;
            SettingsBtn.Enabled = true;

            HighScoreBtn.Visible = true;
            HighScoreBtn.Enabled = true;
        }

        //method that changes the state of the game
        //we will be using this a lot
        private void UpdateScreen(object sender, EventArgs e) {
            //this makes the game canvas redraw itself
            //hello
            Game_Canvas.Invalidate();
        }


        //this is called everytime the user changes the size of the game
        private void Wampus_Warriors_SizeChanged(Object sender, EventArgs e) {
            Console.WriteLine();
            startScreenSetUp();
        }

        //button to start a new game
        private void StartBtn_Click(object sender, EventArgs e) {
            StartGame();
        }

        //detects if a key is currently being pressed
        private void Wampus_Warriors_KeyDown(object sender, KeyEventArgs e) {
            Input.changeState(e.KeyCode, true);
        }

        //detects when a key is released
        private void Wampus_Warriors_KeyUp(object sender, KeyEventArgs e) {
            Input.changeState(e.KeyCode, false);
        }

        //method used to paint the game canvas
        private void Game_Canvas_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            if (playGame) {
                //init the game canvas
                //will eventually implement UI classes and use prefab images
                Game_Canvas.BackColor = Color.SandyBrown;
            }

            else {
                Game_Canvas.BackColor = Color.Black;
            }
        }
    }
}
