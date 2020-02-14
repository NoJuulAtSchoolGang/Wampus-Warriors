using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wampus_Warriors.Wampus_Code {
    public class Input {

        //cool data structure thing
        private static Hashtable keyTable = new Hashtable();

        //checks if a registered key has been pressed
        //will return false when key is released
        public static bool keyPressed(Keys key) {
            if (keyTable[key] == null) {
                return false;
            }
            return (bool)keyTable[key];
        }

        //changes the state to positive or negative for a key
        public static void changeState(Keys k, bool state) {
            keyTable[k] = state;
        }
    }
}
