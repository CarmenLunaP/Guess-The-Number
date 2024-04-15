namespace Guess_The_Number
{
    public abstract class Player
    {
        public string Name { get; protected set; }
        public int LastGuess;
        public List<int> Guesses;

        //Contructor de la clase abstracta player
        protected Player(string name)
        {
            Name = name;
            LastGuess = 0;
            Guesses = new List<int>();
        }

        //Metodo abstracto que sera usado en Huma y AIP player
        public abstract void MakeGuess();

        //Metodo donde atrapo el ultimo intento del jugador
        public int GetLastGuess()
        {
            return LastGuess;
        }

        //Metodo donde reinicio el juego reunicia las suposiciones
        public void ResetLastGuess()
        {
            LastGuess = 0;
        }
    }
}
