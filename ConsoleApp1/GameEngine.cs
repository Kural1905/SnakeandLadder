using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class GameEngine
    {
        private const int WIN_POSITION = 100;
        private Player player1;
        private Player player2;
        private Dice dice;

        public GameEngine()
        {
            player1 = new Player("Player 1");
            player2 = new Player("Player 2");
            dice = new Dice();
        }

        public void StartGame()
        {
            bool isPlayer1Turn = true;

            while (player1.Position < WIN_POSITION && player2.Position < WIN_POSITION)
            {
                Player currentPlayer = isPlayer1Turn ? player1 : player2;

                Console.WriteLine($"{currentPlayer.Name}'s Turn");
                bool playAgain;

                do
                {
                    playAgain = TakeTurn(currentPlayer);
                } while (playAgain);

                // Switch turns unless player gets a ladder (handled in TakeTurn)
                isPlayer1Turn = !playAgain ? !isPlayer1Turn : isPlayer1Turn;
            }

            //Winner Announcement
            Console.WriteLine($"{GetWinner().Name} wins the game in {GetWinner().DiceRolls} rolls!");
        }

        private bool TakeTurn(Player player)
        {
            int roll = dice.Roll();
            player.DiceRolls++;

            int option = dice.GetOption(); // 0 = No Play, 1 = Ladder, 2 = Snake
            string action = option == 0 ? "No Play" : option == 1 ? "Ladder" : "Snake";

            Console.WriteLine($"Rolled: {roll} | Action: {action}");

            switch (option)
            {
                case 0:
                    // No Play, stay same
                    break;
                case 1:
                    player.Position += roll;
                    if (player.Position > 100)
                        player.Position -= roll;
                    Console.WriteLine("Ladder! Move forward.");
                    break;
                case 2:
                    player.Position -= roll;
                    if (player.Position < 0) player.Position = 0;
                    Console.WriteLine("Snake! Move back.");
                    break;
            }

            Console.WriteLine($"{player.Name} Position: {player.Position}");

            return option == 1; // If Ladder, play again
        }

        private Player GetWinner()
        {
            return player1.Position == 100 ? player1 : player2;
        }
    }
}
