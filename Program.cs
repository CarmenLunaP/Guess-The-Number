using Guess_The_Number;

//Bienvenida al Jugador. 

Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine($"Welcome to the Guess the Number game! {Environment.NewLine}In this game, you'll have to guess a secret number between 1 and 100.");
Console.WriteLine("Please enter your name to begin the game:");
var name = Console.ReadLine();
Console.WriteLine($"{Environment.NewLine}Hello {name}  {Environment.NewLine}Ready to challenge J.A.R.V.I.S.? Let the game begin!{Environment.NewLine}");

Console.ResetColor();

//inicio las intancias

// HumanPlayer humanPlayer = new HumanPlayer(name);
HumanPlayer humanPlayer = new HumanPlayer(name ?? throw new ArgumentNullException(nameof(name)));

AIPlayer aiPlayer = new AIPlayer();

Game game = new Game(humanPlayer, aiPlayer);
game.PlayGame();

