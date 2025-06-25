using System;

namespace SnakeLadderGame
{
    public class Dice
    {
        private Random random;

        public Dice()
        {
            random = new Random();
        }

        // Simulates rolling a 6-sided die
        public int Roll()
        {
            return random.Next(1, 7);
        }

        // Random option: 0 = No Play, 1 = Ladder, 2 = Snake
        public int GetOption()
        {
            return random.Next(0, 3);
        }
    }
}
