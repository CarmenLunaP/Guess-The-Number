using System; // Asegúrate de importar el espacio de nombres System

namespace Guess_The_Number
{
    public class Game // Asegúrate de que la clase Game sea pública
    {
        public void PlayGame()
        {
            Random random = new Random();
            bool playAgain = true;
            while (playAgain)
            {
                int guess = 0;
                int guesses = 0;
                int number = random.Next(1, 101);
                while (guess != number)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Can you guess the secret number? Enter a number between 1 and 100:");
                    Console.ResetColor();
                    guess = Convert.ToInt32(Console.ReadLine());
                    guesses++;
                    if (guess > number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(guess + " is too high!");
                        Console.WriteLine("Try a lower number.");
                        Console.ResetColor();
                    }
                    else if (guess < number)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(guess + " is too low!");
                        Console.WriteLine("Try a higher number.");
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(guess + " is Correct! You guessed it in " + guesses + " attempts.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Would you like to play again? (y/n)");
                Console.ResetColor();
                string playAgainInput = Console.ReadLine();
                playAgain = (playAgainInput.ToLower() == "y");
            }
        }
    }
}




// namespace Guess_The_Number;
// using Guess_The_Number;


//  class Game
// {
//     public void PlayGame()
//     {

//         Random random = new Random();
//         // declaro un bolleano para reinicar el juego al final.
//         bool playAgain = true;
//         // declaro el bucle que es el cuerpo de juego cada vez que el usuario quiera continuar jugando
//         while (playAgain)
//         {
//             int guess = 0; // el numero que el usuario adiviva
//             int guesses = 0; // numeros de intentos
//             int number = random.Next(1, 101); //genero el aleatorio en la variable number

//             // declaro el bucle para inciar la partida
//             while (guess != number)
//             {

//                 // Solicitar al usuario que ingrese su suposición
//                 Console.ForegroundColor = ConsoleColor.Cyan;
//                 Console.Write("Can you guess the secret number? Enter a number between 1 and 100:");
//                 Console.ResetColor();

//                 // Lee la entrada del usuario y convertirla a un número entero
//                 guess = Convert.ToInt32(Console.ReadLine());
//                 // Incremento el contador de intentos
//                 guesses++;
//                 // agrego las condiciones de acuerdo a ellas doy pistas al usuario
//                 if (guess > number)
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine(guess + " is too high!");
//                     Console.WriteLine("Try a lower number.");
//                     Console.ResetColor();
//                 }
//                 else if (guess < number)
//                 {
//                     Console.ForegroundColor = ConsoleColor.Yellow;
//                     Console.WriteLine(guess + " is too low!");
//                     Console.WriteLine("Try a higher number.");
//                     Console.ResetColor();
//                 }
//             }

//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine(guess + " is Correct! You guessed it in " + guesses + " attempts.");
//             Console.ResetColor();

//             // Pregunto al usuario si desea jugar nuevamente
//             Console.ForegroundColor = ConsoleColor.Cyan;
//             Console.WriteLine("Would you like to play again? (y/n)");
//             Console.ResetColor();
//             //leo la respuesta
//             string playAgainInput = Console.ReadLine();
//             // activo el play again
//             playAgain = (playAgainInput.ToLower() == "y");
//         }
//     }
// }
