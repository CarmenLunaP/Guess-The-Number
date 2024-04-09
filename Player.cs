using System;

namespace Guess_The_Number
{
    public class Player
    {
        public string Name { get; private set; }
        public int LastGuess { get; private set; }

        public Player(string name)
        {
            Name = name;
            LastGuess = 0;
        }

        public void MakeGuess()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Can you guess the secret number? Enter a number between 1 and 100:");
            Console.ResetColor();
            LastGuess = Convert.ToInt32(Console.ReadLine());
        }

        // Método para reiniciar el último intento del jugador
        public void ResetLastGuess()
        {
            LastGuess = 0;
        }
    }
}
