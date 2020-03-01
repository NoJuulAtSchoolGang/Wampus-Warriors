using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wampus_Warriors.Wampus_Code {
    class User {
        public int score { get; set; }
        public String name { get; set; }

        public User(int score, String name) {
            this.score = score;
            this.name = name;
        }

        public int CompareTo(User other) {
            if (this.score < other.score) {
                return 1;
            }
            if (this.score == other.score) {
                return 0;
            }
            else {
                return -1;
            }
        }

        override
        public String ToString() {
            return score + " " + name;
        }
    }
}
