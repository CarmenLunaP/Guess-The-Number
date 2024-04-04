
namespace Guess_The_Number;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan; // asigno el color
        Console.WriteLine("Welcome to the Guess the Number game! In this game, you'll have to guess a secret number between 1 and 100.");
        // Console.ResetColor(); // quito el color

        // Console.ForegroundColor = ConsoleColor.Cyan; // asigno el color
        Console.WriteLine("Please enter your name to begin the game:");
        // Console.ResetColor(); // quito el color

        var name = Console.ReadLine();
        Console.WriteLine($"{Environment.NewLine}Hello {name}, Welcome to Guess the Number game");
        Console.ResetColor(); // quito el color
        // Crear una instancia de Game y llamar al método PlayGame
        Game game = new Game();
        game.PlayGame();

    }
}
