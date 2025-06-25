using System;

namespace SnakeLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            GameEngine game = new GameEngine();
            game.StartGame();
        }
    }
}
