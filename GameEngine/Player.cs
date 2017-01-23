using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Player
    {
        public string Pseudo { get; set; }

        public Player(string name)
        {
            Pseudo = name;
        }
    }
}
