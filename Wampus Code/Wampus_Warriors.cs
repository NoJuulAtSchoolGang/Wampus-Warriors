using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wampus_Warriors {
    public partial class Wampus_Warriors : Form {

        //this is the constructor
        public Wampus_Warriors() {
            InitializeComponent();
            startScreenSetUp();
        }

        //sets up the the start screen buttons relative to the screen size
        public void startScreenSetUp() {
            //sets the size of the game canvas to the size of the form that the game is on
            Game_Canvas.Size = this.ClientSize;

            //dictates the size of the buttons
            Size ButtonLocation = new Size(Game_Canvas.Width / 8, Game_Canvas.Height / 5);

            //sets buttons to same size
            StartBtn.Size = ButtonLocation;
            HighScoreBtn.Size = ButtonLocation;
            SettingsBtn.Size = ButtonLocation;
            ExitBtn.Size = ButtonLocation;

            //sets the location of the buttons relative to each other
            StartBtn.Location = new Point((int)(this.Location.X + this.ClientSize.Width * 0.25 - ButtonLocation.Width/2), (int)(this.Location.Y + this.Height * 0.25 - ButtonLocation.Height/2));
            HighScoreBtn.Location = new Point((int)(this.Location.X + this.ClientSize.Width * 0.75 - ButtonLocation.Width/2), (int)(this.Location.Y + this.Height * 0.25 - ButtonLocation.Height/2));
            SettingsBtn.Location = new Point((int)(this.Location.X + this.ClientSize.Width * 0.25 - ButtonLocation.Width / 2), (int)(this.Location.Y + this.Height * 0.75 - ButtonLocation.Height / 2));
            ExitBtn.Location = new Point((int)(this.Location.X + this.ClientSize.Width * 0.75 - ButtonLocation.Width / 2), (int)(this.Location.Y + this.Height * 0.75 - ButtonLocation.Height / 2));
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
            
        }

        //method that changes the state of the game
        //we will be using this a lot
        private void UpdateScreen(object sender, EventArgs e) {

            //this makes the game canvas redraw itself
            Game_Canvas.Invalidate();
        }


        //this is called everytime the user changes the size of the game
        private void Wampus_Warriors_SizeChanged(Object sender, EventArgs e) {
            startScreenSetUp();
        }

        //button to start a new game
        private void StartBtn_Click(object sender, EventArgs e) {
            StartGame();
        }
    }
}
