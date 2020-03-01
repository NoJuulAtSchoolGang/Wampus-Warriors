using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Wampus_Warriors.Wampus_Code;

namespace Wampus_Warriors {
    public partial class Wampus_Warriors : Form {

        //bool detects if game is currently being played
        //used to determine whether certain things should be executed or not
        private bool playGame = false;

        //double contains the value to multiply each pixel by to fit the resolution of screen
        //based on a standard size of 640 x 480
        private double scaleFactor = 1;

        //contains the standard size of the game
        //used to determine the size of the picturebox C# control the game uses for graphics
        public static readonly Size STANDARD_SIZE = new Size(640, 480);

        //contains the current direction of the player so it can be sent to the UI
        private String direction = "up";

        //Used by all classes that read data from a file
        //contains the absolute path to the main dir 
        public static readonly String DIR_LOCATION = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();


        //These are all the game objects that will be used in the game
        //will be reinstantiated every time the game runs
        private UI ui;
        private GameLocation game_location;
        private Player player;
        private Trivia trivia;
        private HighScore hs;
        private Cave cave;

        public Wampus_Warriors() {
            InitializeComponent();
            startScreenSetUp();
        }

        //method to return the preferred size of the game canvas
        //updates the conversion factor as well
        //called every time the screen is resized
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

        //sets up all the initial features of the game like the screen size and the start screen so it looks clean
        
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
            GameTimer.Interval = 5;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();

            //bool to indicate game is being played
            playGame = true;

            //initializes the game objects
            ui = new UI(scaleFactor);
            cave = new Cave();
            game_location = new GameLocation(cave);
            hs = new HighScore();
            trivia = new Trivia();
            player = new Player();

           
            
        }

        //this method will be called once the game is won or lost
        //will stop the game timer and enable the start screen buttons
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

            movePlayer();
            
            //this makes the game canvas redraw itself
            //hello
            Game_Canvas.Invalidate();
        }

        //method moves player around on screen
        //will add collision detection in the future
        private void movePlayer() {
            if (Input.keyPressed(Keys.W)) {
                player.setY(player.getY() - (int)(scaleFactor * 5));
                direction = "up";
            }

            if (Input.keyPressed(Keys.S)) {
                player.setY(player.getY() + (int)(scaleFactor * 5));
                direction = "down";

            }

            if (Input.keyPressed(Keys.A)) {
                player.setX(player.getX() - (int)(scaleFactor * 5));
                if (!Input.keyPressed(Keys.W) && !Input.keyPressed(Keys.S)) {
                    direction = "right";
                }

            }
            if (Input.keyPressed(Keys.D)) {
                player.setX(player.getX() + (int)(scaleFactor * 5));
                if (!Input.keyPressed(Keys.W) && !Input.keyPressed(Keys.S)) {
                    direction = "left";
                }
            }
        }

        //this is called everytime the user changes the size of the game
        private void Wampus_Warriors_SizeChanged(Object sender, EventArgs e) {
            Console.WriteLine();
            startScreenSetUp();
            if (playGame) {
                ui.updateConversionFactor(this.scaleFactor);
            }
        }

        //button to start a new game
        //once the start btn is pressed the game is started
        private void StartBtn_Click(object sender, EventArgs e) {
            StartGame();
        }

        //button to end game


        //detects if a key is currently being pressed
        //will set the key in the Input class to true
        private void Wampus_Warriors_KeyDown(object sender, KeyEventArgs e) {
            Input.changeState(e.KeyCode, true);
        }

        //detects when a key is released
        //will set the key in the Input class to false
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
                ui.drawPlayer(player, direction, g);

                
            }

            else {
                Game_Canvas.BackColor = Color.Black;
            }
        }

        //ends the program
        private void ExitBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
