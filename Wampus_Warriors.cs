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

        }

      

    }
}
