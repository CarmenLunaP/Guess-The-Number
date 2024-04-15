// Program.cs
using System;

namespace Guess_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Welcome to the Guess the Number game! {Environment.NewLine}In this game, you'll have to guess a secret number between 1 and 100.");
            Console.WriteLine("Please enter your name to begin the game:");
            var name = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}Hello {name}  {Environment.NewLine}Can you guess the secret number?");
            Console.ResetColor();

            HumanPlayer humanPlayer = new HumanPlayer(name);
            AIPlayer aiPlayer = new AIPlayer();
            Game game = new Game(humanPlayer, aiPlayer);
            game.PlayGame();
        }
    }
}


// using System;

// namespace Guess_The_Number
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.ForegroundColor = ConsoleColor.Cyan;
//             Console.WriteLine($"Welcome to the Guess the Number game! {Environment.NewLine}In this game, you'll have to guess a secret number between 1 and 100.");
//             Console.WriteLine("Please enter your name to begin the game:");
//             var name = Console.ReadLine();
//             Console.WriteLine($"{Environment.NewLine}Hello {name}  {Environment.NewLine}Can you guess the secret number?");
//             Console.ResetColor();


//             Player player = new Player(name = "" ); // Crear una instancia de Player
//             Game game = new Game(player); // Pasar la instancia de Player al constructor de Game
//             game.PlayGame();
//         }
//     }
// }

