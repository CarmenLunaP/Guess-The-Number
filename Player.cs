using System;

namespace Guess_The_Number
{
    public class Player
    {
        public string Name { get; private set; }
        private int lastGuess;

        public Player(string name)
        {
            Name = name;
            lastGuess = 0;
        }

        public void MakeGuess()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter a number between 1 and 100:");
            Console.ResetColor();
            lastGuess = Convert.ToInt32(Console.ReadLine());
        }

        public int GetLastGuess()
        {
            return lastGuess;
        }

        public void ResetLastGuess()
        {
            lastGuess = 0;
        }
    }
}

