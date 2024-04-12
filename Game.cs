using System;

namespace Guess_The_Number
{
    public class Game
    {
        private readonly Player player;
        private int secretNumber;

        public Game(Player player)
        {
            this.player = player;
            InitializeGame();
        }

        public void PlayGame()
        {
            bool playAgain = true;
            while (playAgain)
            {
                int guesses = 0;

                while (playAgain)
                {
                    player.ResetLastGuess();
                    while (player.GetLastGuess() != secretNumber)
                    {
                        player.MakeGuess(); // Llama al método MakeGuess() de Player
                        guesses++;

                        if (player.GetLastGuess() > secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(player.GetLastGuess() + " is too high!");
                            Console.WriteLine("Try a lower number.");
                            Console.ResetColor();
                        }
                        else if (player.GetLastGuess() < secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(player.GetLastGuess() + " is too low!");
                            Console.WriteLine("Try a higher number.");
                            Console.ResetColor();
                        }
                    }

                    if (CheckGuess()) // Verificar si la conjetura es correcta
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(player.GetLastGuess() + " is Correct! You guessed it in " + guesses + " attempts.");
                        Console.ResetColor();
                        break; // Finalizar el juego si la conjetura es correcta
                    }
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Would you like to play again? (y/n)");
                Console.ResetColor();

                var playAgainInput = Console.ReadLine();
                if (playAgainInput?.ToLower() == "n")
                {
                    break;
                }
                else if (playAgainInput?.ToLower() != "y")
                {
                    Console.WriteLine("Invalid input. Please enter 'y' to play again or 'n' to quit.");
                }
                else
                {
                    InitializeGame();
                }
            }
        }

        private void InitializeGame()
        {
            RandomNumberGenerator();
        }

        private void RandomNumberGenerator()
        {
            Random random = new Random();
            secretNumber = random.Next(1, 101);
        }

        private bool CheckGuess()
        {
            return player.GetLastGuess() == secretNumber;
        }
    }
}

