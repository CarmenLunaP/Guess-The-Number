// Player.cs
using System;
using System.Collections.Generic;

namespace Guess_The_Number
{
    public abstract class Player
    {
        public string Name { get; protected set; }
        public int LastGuess;
        public List<int> Guesses;

        protected Player(string name)
        {
            Name = name;
            LastGuess = 0;
            Guesses = new List<int>();
        }

        public abstract void MakeGuess();

        public int GetLastGuess()
        {
            return LastGuess;
        }

        public void ResetLastGuess()
        {
            LastGuess = 0;
        }
    }
}



// using System;

// namespace Guess_The_Number
// {
//     public class Player
//     {
//         public string Name { get; private set; }
//         private int lastGuess;

//         public Player(string name)
//         {
//             Name = name;
//             lastGuess = 0;
//         }

//         public void MakeGuess()
//         {
//             Console.ForegroundColor = ConsoleColor.Cyan;
//             Console.Write("Enter a number between 1 and 100:");
//             Console.ResetColor();
//             lastGuess = Convert.ToInt32(Console.ReadLine());
//         }

//         public int GetLastGuess()
//         {
//             return lastGuess;
//         }

//         public void ResetLastGuess()
//         {
//             lastGuess = 0;
//         }
//     }
// }

