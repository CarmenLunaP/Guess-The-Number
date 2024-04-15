// AIPlayer.cs
using System;

namespace Guess_The_Number
{
    public class AIPlayer : Player
    {
        private readonly Random _random;

        public AIPlayer() : base("AI")
        {
            _random = new Random();
        }

        public override void MakeGuess()
        {
            LastGuess = _random.Next(1, 101);
            Guesses.Add(LastGuess);
        }
    }
}
