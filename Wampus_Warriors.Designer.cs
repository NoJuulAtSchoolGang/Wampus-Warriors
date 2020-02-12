namespace Wampus_Warriors {
    partial class Wampus_Warriors {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Game_Canvas = new System.Windows.Forms.PictureBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.HighScoreBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.ControlsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Game_Canvas
            // 
            this.Game_Canvas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Game_Canvas.Location = new System.Drawing.Point(0, 0);
            this.Game_Canvas.Name = "Game_Canvas";
            this.Game_Canvas.Size = new System.Drawing.Size(640, 480);
            this.Game_Canvas.TabIndex = 0;
            this.Game_Canvas.TabStop = false;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(87, 100);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(97, 34);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start Game";
            this.StartBtn.UseVisualStyleBackColor = true;
            // 
            // HighScoreBtn
            // 
            this.HighScoreBtn.Location = new System.Drawing.Point(472, 100);
            this.HighScoreBtn.Name = "HighScoreBtn";
            this.HighScoreBtn.Size = new System.Drawing.Size(97, 34);
            this.HighScoreBtn.TabIndex = 2;
            this.HighScoreBtn.Text = "button2";
            this.HighScoreBtn.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(87, 307);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(106, 35);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            // 
            // ControlsBtn
            // 
            this.ControlsBtn.Location = new System.Drawing.Point(472, 307);
            this.ControlsBtn.Name = "ControlsBtn";
            this.ControlsBtn.Size = new System.Drawing.Size(107, 35);
            this.ControlsBtn.TabIndex = 4;
            this.ControlsBtn.Text = "Controls";
            this.ControlsBtn.UseVisualStyleBackColor = true;
            // 
            // Wampus_Warriors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.ControlsBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.HighScoreBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.Game_Canvas);
            this.Name = "Wampus_Warriors";
            this.Text = "Wampus Warriors";
            ((System.ComponentModel.ISupportInitialize)(this.Game_Canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Game_Canvas;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button HighScoreBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button ControlsBtn;
    }
}

