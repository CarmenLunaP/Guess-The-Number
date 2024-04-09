using System;

namespace Guess_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Guess the Number game! In this game, you'll have to guess a secret number between 1 and 100.");

            Console.WriteLine("Please enter your name to begin the game:");
            var name = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}Hello {name}, Welcome to Guess the Number game");
            Console.ResetColor();

            Game game = new Game(name);
            game.PlayGame();
        }
    }
}

