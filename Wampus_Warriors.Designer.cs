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
            // Wampus_Warriors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.Game_Canvas);
            this.Name = "Wampus_Warriors";
            this.Text = "Wampus Warriors";
            ((System.ComponentModel.ISupportInitialize)(this.Game_Canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Game_Canvas;
    }
}

