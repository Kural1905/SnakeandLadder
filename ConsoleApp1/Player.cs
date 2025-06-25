using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class Player
    {
        public string Name { get; }
        public int Position { get; set; }
        public int DiceRolls { get; set; }

        public Player(string name)
        {
            Name = name;
            Position = 0;
            DiceRolls = 0;
        }
    }
}

