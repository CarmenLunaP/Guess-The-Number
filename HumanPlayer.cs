// HumanPlayer.cs
using System;

namespace Guess_The_Number
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override void MakeGuess()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter a number between 1 and 100:");
            Console.ResetColor();
            LastGuess = Convert.ToInt32(Console.ReadLine());
            Guesses.Add(LastGuess);
        }
    }
}
