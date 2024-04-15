// Game.cs
using System;

namespace Guess_The_Number
{
    public class Game
    {
        private readonly HumanPlayer _humanPlayer;
        private readonly AIPlayer _aiPlayer;
        private int _secretNumber;
        private int _humanGuesses;
        private int _aiGuesses;

        public Game(HumanPlayer humanPlayer, AIPlayer aiPlayer)
        {
            _humanPlayer = humanPlayer;
            _aiPlayer = aiPlayer;
            InitializeGame();
        }

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

                    Console.WriteLine($"The AI has guessed {_aiPlayer.GetLastGuess()}.");
                    if (_aiPlayer.GetLastGuess() > _secretNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{_aiPlayer.GetLastGuess()} is too high!");
                        Console.WriteLine("Try a lower number.");
                        Console.ResetColor();
                    }
                    else if (_aiPlayer.GetLastGuess() < _secretNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{_aiPlayer.GetLastGuess()} is too low!");
                        Console.WriteLine("Try a higher number.");
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
                            Console.WriteLine(_humanPlayer.GetLastGuess() + " is too high!");
                            Console.WriteLine("Try a lower number.");
                            Console.ResetColor();
                        }
                        else if (_humanPlayer.GetLastGuess() < _secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(_humanPlayer.GetLastGuess() + " is too low!");
                            Console.WriteLine("Try a higher number.");
                            Console.ResetColor();
                        }

                        if (_humanPlayer.GetLastGuess() == _secretNumber)
                            break;

                        _aiGuesses++;
                        _aiPlayer.MakeGuess();

                        if (_aiPlayer.GetLastGuess() > _secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(_aiPlayer.GetLastGuess() + " is too high!");
                            Console.WriteLine("Try a lower number.");
                            Console.ResetColor();
                        }
                        else if (_aiPlayer.GetLastGuess() < _secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(_aiPlayer.GetLastGuess() + " is too low!");
                            Console.WriteLine("Try a higher number.");
                            Console.ResetColor();
                        }
                    }

                    if (CheckGuess())
                    {
                        if (_humanPlayer.GetLastGuess() == _secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(_humanPlayer.GetLastGuess() + " is Correct! You guessed it in " + _humanGuesses + " attempts.");
                            Console.ResetColor();
                        }
                        else if (_aiPlayer.GetLastGuess() == _secretNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(_aiPlayer.GetLastGuess() + " is Correct! AI guessed it in " + _aiGuesses + " attempts.");
                            Console.ResetColor();
                        }
                        break;
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
            _secretNumber = random.Next(1, 101);
            // Console.WriteLine($"The AI has guessed {_aiPlayer.GetLastGuess()}. Let's see if you can beat it!");
        }

        private bool CheckGuess()
        {
            return _humanPlayer.GetLastGuess() == _secretNumber || _aiPlayer.GetLastGuess() == _secretNumber;
        }
    }
}





// // Game.cs
// using System;

// namespace Guess_The_Number
// {
//     public class Game
//     {
//         private readonly HumanPlayer _humanPlayer;
//         private readonly AIPlayer _aiPlayer;
//         private int _secretNumber;
//         private bool _isHumanTurn;

//         public Game(HumanPlayer humanPlayer, AIPlayer aiPlayer)
//         {
//             _humanPlayer = humanPlayer;
//             _aiPlayer = aiPlayer;
//             InitializeGame();
//         }

//         public void PlayGame()
//         {
//             bool playAgain = true;
//             while (playAgain)
//             {
//                 while (playAgain)
//                 {
//                     _isHumanTurn = true;
//                     int humanGuesses = 0;
//                     int aiGuesses = 0;

//                     _humanPlayer.ResetLastGuess();
//                     _aiPlayer.ResetLastGuess();

//                     while ((_isHumanTurn && _humanPlayer.GetLastGuess() != _secretNumber) ||
//                            (!_isHumanTurn && _aiPlayer.GetLastGuess() != _secretNumber))
//                     {
//                         if (_isHumanTurn)
//                         {
//                             _humanPlayer.MakeGuess();
//                             humanGuesses++;
//                         }
//                         else
//                         {
//                             _aiPlayer.MakeGuess();
//                             aiGuesses++;
//                         }

//                         int lastGuess = _isHumanTurn ? _humanPlayer.GetLastGuess() : _aiPlayer.GetLastGuess();

//                         if (lastGuess > _secretNumber)
//                         {
//                             Console.ForegroundColor = ConsoleColor.Red;
//                             Console.WriteLine(lastGuess + " is too high!");
//                             Console.WriteLine("Try a lower number.");
//                             Console.ResetColor();
//                         }
//                         else if (lastGuess < _secretNumber)
//                         {
//                             Console.ForegroundColor = ConsoleColor.Yellow;
//                             Console.WriteLine(lastGuess + " is too low!");
//                             Console.WriteLine("Try a higher number.");
//                             Console.ResetColor();
//                         }

//                         _isHumanTurn = !_isHumanTurn;
//                     }

//                     if (CheckGuess())
//                     {
//                         Console.ForegroundColor = ConsoleColor.Green;
//                         Console.WriteLine((_isHumanTurn ? _humanPlayer.GetLastGuess() : _aiPlayer.GetLastGuess()) +
//                                           " is Correct! You guessed it in " + (humanGuesses + aiGuesses) + " attempts.");
//                         Console.ResetColor();
//                         break;
//                     }
//                 }

//                 Console.ForegroundColor = ConsoleColor.Cyan;
//                 Console.WriteLine("Would you like to play again? (y/n)");
//                 Console.ResetColor();

//                 var playAgainInput = Console.ReadLine();
//                 if (playAgainInput?.ToLower() == "n")
//                 {
//                     break;
//                 }
//                 else if (playAgainInput?.ToLower() != "y")
//                 {
//                     Console.WriteLine("Invalid input. Please enter 'y' to play again or 'n' to quit.");
//                 }
//                 else
//                 {
//                     InitializeGame();
//                 }
//             }
//         }

//         private void InitializeGame()
//         {
//             RandomNumberGenerator();
//             Console.WriteLine($"The AI has guessed {_aiPlayer.GetLastGuess()}. Let's see if you can beat it!");
//         }

//         private void RandomNumberGenerator()
//         {
//             Random random = new Random();
//             _secretNumber = random.Next(1, 101);
//         }

//         private bool CheckGuess()
//         {
//             return _humanPlayer.GetLastGuess() == _secretNumber || _aiPlayer.GetLastGuess() == _secretNumber;
//         }
//     }
// }







// using System;

// namespace Guess_The_Number
// {
//     public class Game
//     {
//         private readonly Player player;
//         private int secretNumber;

//         public Game(Player player)
//         {
//             this.player = player;
//             InitializeGame();
//         }

//         public void PlayGame()
//         {
//             bool playAgain = true;
//             while (playAgain)
//             {
//                 int guesses = 0;

//                 while (playAgain)
//                 {
//                     player.ResetLastGuess();
//                     while (player.GetLastGuess() != secretNumber)
//                     {
//                         player.MakeGuess(); // Llama al método MakeGuess() de Player
//                         guesses++;

//                         if (player.GetLastGuess() > secretNumber)
//                         {
//                             Console.ForegroundColor = ConsoleColor.Red;
//                             Console.WriteLine(player.GetLastGuess() + " is too high!");
//                             Console.WriteLine("Try a lower number.");
//                             Console.ResetColor();
//                         }
//                         else if (player.GetLastGuess() < secretNumber)
//                         {
//                             Console.ForegroundColor = ConsoleColor.Yellow;
//                             Console.WriteLine(player.GetLastGuess() + " is too low!");
//                             Console.WriteLine("Try a higher number.");
//                             Console.ResetColor();
//                         }
//                     }

//                     if (CheckGuess()) // Verificar si la conjetura es correcta
//                     {
//                         Console.ForegroundColor = ConsoleColor.Green;
//                         Console.WriteLine(player.GetLastGuess() + " is Correct! You guessed it in " + guesses + " attempts.");
//                         Console.ResetColor();
//                         break; // Finalizar el juego si la conjetura es correcta
//                     }
//                 }

//                 Console.ForegroundColor = ConsoleColor.Cyan;
//                 Console.WriteLine("Would you like to play again? (y/n)");
//                 Console.ResetColor();

//                 var playAgainInput = Console.ReadLine();
//                 if (playAgainInput?.ToLower() == "n")
//                 {
//                     break;
//                 }
//                 else if (playAgainInput?.ToLower() != "y")
//                 {
//                     Console.WriteLine("Invalid input. Please enter 'y' to play again or 'n' to quit.");
//                 }
//                 else
//                 {
//                     InitializeGame();
//                 }
//             }
//         }

//         private void InitializeGame()
//         {
//             RandomNumberGenerator();
//         }

//         private void RandomNumberGenerator()
//         {
//             Random random = new Random();
//             secretNumber = random.Next(1, 101);
//         }

//         private bool CheckGuess()
//         {
//             return player.GetLastGuess() == secretNumber;
//         }
//     }
// }

