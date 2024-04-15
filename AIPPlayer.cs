namespace Guess_The_Number
{
    public class AIPlayer : Player
    {
        private readonly Random _random;

        //Contructor
        public AIPlayer() : base("J.A.R.V.I.S.")
        {
            _random = new Random();
        }

        //Implemento MakeGuess para la IA
        public override void MakeGuess()
        {
            LastGuess = _random.Next(1, 101);
            Guesses.Add(LastGuess);
        }
    }
}
