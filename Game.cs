using System;

namespace Guess_The_Number
{
    public class Game
    {
        private readonly Player player;
        private readonly int secretNumber;

        public Game(string playerName)
        {
            Random random = new Random();
            secretNumber = random.Next(1, 101);
            player = new Player(playerName);
        }

        public void PlayGame()
        {
            bool playAgain = true;

            while (playAgain)
            {
                int guesses = 0;

                // Console.WriteLine($"Hello {player.Name}, Welcome to Guess the Number game");

                while (true)
                {
                    player.ResetLastGuess();
                    while (player.LastGuess != secretNumber)
                    {
                        player.MakeGuess();
                        guesses++;

                        if (player.LastGuess > secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(player.LastGuess + " is too high!");
                            Console.WriteLine("Try a lower number.");
                            Console.ResetColor();
                        }
                        else if (player.LastGuess < secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(player.LastGuess + " is too low!");
                            Console.WriteLine("Try a higher number.");
                            Console.ResetColor();
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(player.LastGuess + " is Correct! You guessed it in " + guesses + " attempts.");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Would you like to play again? (y/n)");
                    Console.ResetColor();

                    var playAgainInput = Console.ReadLine();
                    if (playAgainInput.ToLower() == "y")
                    {
                        break;
                    }
                    else if (playAgainInput.ToLower() == "n")
                    {
                        playAgain = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' to play again or 'n' to quit.");
                    }
                }
            }
        }
    }
}


