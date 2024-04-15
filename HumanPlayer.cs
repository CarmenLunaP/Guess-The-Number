namespace Guess_The_Number
{
    public class HumanPlayer : Player
    {

        //Contructor
        public HumanPlayer(string name) : base(name)
        {
        }

        //Implemento MakeGuess para el humano
        public override void MakeGuess()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Environment.NewLine}{Name}, It's your turn!. Enter a number between 1 and 100:");
            Console.ResetColor();
            LastGuess = Convert.ToInt32(Console.ReadLine());
            Guesses.Add(LastGuess);
        }
    }
}
