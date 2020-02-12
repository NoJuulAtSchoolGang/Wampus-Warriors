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
        public Wampus_Warriors() {
            InitializeComponent();
            gameSetUp();
        }

        public void gameSetUp() {
            Game_Canvas.Size = this.ClientSize;

            Size ButtonLocation = new Size(Game_Canvas.Width / 8, Game_Canvas.Height / 5);

            StartBtn.Size = ButtonLocation;
            HighScoreBtn.Size = ButtonLocation;
            SettingsBtn.Size = ButtonLocation;
            ControlsBtn.Size = ButtonLocation;

            StartBtn.Location = new Point((int)(this.Location.X + this.ClientSize.Width * 0.25 - ButtonLocation.Width/2), (int)(this.Location.Y + this.Height * 0.25 - ButtonLocation.Height/2));
            HighScoreBtn.Location = new Point((int)(this.Location.X + this.ClientSize.Width * 0.75 - ButtonLocation.Width/2), (int)(this.Location.Y + this.Height * 0.25 - ButtonLocation.Height/2));
            SettingsBtn.Location = new Point((int)(this.Location.X + this.ClientSize.Width * 0.25 - ButtonLocation.Width / 2), (int)(this.Location.Y + this.Height * 0.75 - ButtonLocation.Height / 2));
            ControlsBtn.Location = new Point((int)(this.Location.X + this.ClientSize.Width * 0.75 - ButtonLocation.Width / 2), (int)(this.Location.Y + this.Height * 0.75 - ButtonLocation.Height / 2));
        }

        private void StartGame() {
            StartBtn.Visible = false;
            StartBtn.Enabled = false;

            ControlsBtn.Visible = false;
            ControlsBtn.Enabled = false;

            SettingsBtn.Visible = false;
            SettingsBtn.Enabled = false;

            HighScoreBtn.Visible = false;
            HighScoreBtn.Enabled = false;

            this.Focus();

            GameTimer.Interval = 100;
            GameTimer.Tick += UpdateScreen;
            
        }

        private void UpdateScreen(object sender, EventArgs e) {
            Game_Canvas.Invalidate();
        }
        private void Game_Canvas_Click(object sender, EventArgs e) {
            StartGame();
        }

        private void Wampus_Warriors_SizeChanged(Object sender, EventArgs e) {
            gameSetUp();
        }

    }
}
