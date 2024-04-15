namespace Guess_The_Number
{
    public class Game
    {
        private readonly HumanPlayer _humanPlayer;
        private readonly AIPlayer _aiPlayer;
        private int _secretNumber;
        private int _humanGuesses;
        private int _aiGuesses;

        // Constructor
        public Game(HumanPlayer humanPlayer, AIPlayer aiPlayer)
        {
            _humanPlayer = humanPlayer;
            _aiPlayer = aiPlayer;
            InitializeGame();
        }

        // Logica del juego (bucles)
        public void PlayGame()
        {
            bool playAgain = true;
            while (playAgain)
            {
                while (playAgain)
                {
                    _humanGuesses = 0;
                    _aiGuesses = 0;

                    _humanPlayer.ResetLastGuess();
                    _aiPlayer.ResetLastGuess();

                    // Primer intento de la IA
                    _aiGuesses++;
                    _aiPlayer.MakeGuess();

                    Console.WriteLine($"J.A.R.V.I.S. takes his shot! He thinks it's number: {_aiPlayer.GetLastGuess()}.");
                    if (_aiPlayer.GetLastGuess() > _secretNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{_aiPlayer.GetLastGuess()} is too high!. Try a lower number.");
                        // Console.WriteLine("Try a lower number.");
                        Console.ResetColor();
                    }
                    else if (_aiPlayer.GetLastGuess() < _secretNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{_aiPlayer.GetLastGuess()} is too low!. Try a higher number.");
                        // Console.WriteLine("Try a higher number.");
                        Console.ResetColor();
                    }

                    // si es igual que pasa?

                    while (_humanPlayer.GetLastGuess() != _secretNumber && _aiPlayer.GetLastGuess() != _secretNumber)
                    {
                        _humanGuesses++;
                        _humanPlayer.MakeGuess();

                        if (_humanPlayer.GetLastGuess() > _secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(_humanPlayer.GetLastGuess() + " is too high!. Try a lower number.");
                            // Console.WriteLine("Try a lower number.");
                            Console.ResetColor();
                        }
                        else if (_humanPlayer.GetLastGuess() < _secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(_humanPlayer.GetLastGuess() + " is too low!. Try a higher number.");
                            // Console.WriteLine("Try a higher number.");
                            Console.ResetColor();
                        }

                        if (_humanPlayer.GetLastGuess() == _secretNumber)
                            break;

                        _aiGuesses++;
                        _aiPlayer.MakeGuess();

                        if (_aiPlayer.GetLastGuess() > _secretNumber)
                        {
                             Console.WriteLine($"{Environment.NewLine}J.A.R.V.I.S. turn: {_aiPlayer.GetLastGuess()}");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" is too high!. Try a lower number.");
                            // Console.WriteLine("Try a lower number.");
                            Console.ResetColor();
                        }
                        else if (_aiPlayer.GetLastGuess() < _secretNumber)
                        {
                            Console.WriteLine($"{Environment.NewLine}J.A.R.V.I.S. turn: {_aiPlayer.GetLastGuess()}");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" is too low!. Try a higher number.");
                            // Console.WriteLine("Try a higher number.");
                            Console.ResetColor();
                        }
                    }

                    if (CheckGuess())
                    {
                        if (_humanPlayer.GetLastGuess() == _secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(_humanPlayer.GetLastGuess() + " is Correct! You guessed it in " + _humanGuesses + $" attempts.{Environment.NewLine}");
                            Console.ResetColor();
                        }
                        else if (_aiPlayer.GetLastGuess() == _secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(_aiPlayer.GetLastGuess() + " is Correct! AI guessed it in " + _aiGuesses + $" attempts.{Environment.NewLine}");
                            Console.ResetColor();
                        }
                        break;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Would you like to play again? (y/n)");
                var playAgainInput = Console.ReadLine();
                Console.ResetColor();

               
                if (playAgainInput?.ToLower() == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{Environment.NewLine}Thanks for playing! Until next time, let the games continue!{Environment.NewLine}");
                    Console.ResetColor();
                    break;
                }
                else if (playAgainInput?.ToLower() != "y")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Invalid input. Please enter 'y' to play again or 'n' to quit.");
                    Console.ResetColor();
                }
                else
                {
                    InitializeGame();
                }
            }
        }

        //Incializacion del Juego:
        private void InitializeGame()
        {
            RandomNumberGenerator();
        }

        //Generacion del Numero aleatorio
        private void RandomNumberGenerator()
        {
            Random random = new Random();
            _secretNumber = random.Next(1, 101);
            // Console.WriteLine($"The AI has guessed {_aiPlayer.GetLastGuess()}. Let's see if you can beat it!");
        }

        // Verificacion del numero secreto.
        private bool CheckGuess()
        {
            return _humanPlayer.GetLastGuess() == _secretNumber || _aiPlayer.GetLastGuess() == _secretNumber;
        }
    }
}
