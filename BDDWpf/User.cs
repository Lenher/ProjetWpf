using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDWpf
{
    public class User
    {
        public string Pseudo { get; set; }
        public int Score { get; set; }

        public User(string pseudo, int score)
        {
            Pseudo = pseudo;
            Score = score;
        }

        public override string ToString()
        {
            return Pseudo + " avec le score de " + Score;
        }
    }
}
