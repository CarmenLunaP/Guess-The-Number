using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guess_The_Number;

namespace GuessTheNumberTests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void TestGameInitialization()
        {
            // Arrange
            HumanPlayer humanPlayer = new HumanPlayer("name");
            AIPlayer aiPlayer = new AIPlayer();
            
            // Act
            Game game = new Game(humanPlayer, aiPlayer);
            
            // Assert
            Assert.IsNotNull(game);
        }

        [TestMethod]
        public void TestRandomNumberGeneration()
        {
            // Arrange
            HumanPlayer humanPlayer = new HumanPlayer("name");
            AIPlayer aiPlayer = new AIPlayer();
            Game game = new Game(humanPlayer, aiPlayer);
            
            // Act
            game.RandomNumberGenerator();
            int secretNumber = game.GetSecretNumber();
            
            // Assert
            Assert.IsTrue(secretNumber >= 1 && secretNumber <= 100);
        }

     [TestMethod]
    public void CheckGuess_Returns_True_When_Human_Guess_Is_Correct()
    {
        // Arrange
        var humanPlayer = new HumanPlayer("Marcos");
        var aiPlayer = new AIPlayer();
        var game = new Game(humanPlayer, aiPlayer);
        var secretNumber = game.GetSecretNumber();
        humanPlayer.LastGuess = secretNumber; // simulo la susposicion correcta

        // Act
        var result = game.CheckGuess();

        // Assert
        Assert.IsTrue(result);
    }

        // [TestMethod]
        // public void TestHumanPlayerWin()
        // {
        //     // Arrange
        //     HumanPlayer humanPlayer = new HumanPlayer("name");
        //     AIPlayer aiPlayer = new AIPlayer();
        //     Game game = new Game(humanPlayer, aiPlayer);
        //     int secretNumber = game.GetSecretNumber();
            
        //     // Act
        //     humanPlayer.MakeGuess(); // El jugador humano hace un intento ingresando un número
            
        //     // Assert
        //     Assert.IsTrue(game.CheckGuess()); // Verificamos si el juego reconoce la adivinanza del jugador humano como correcta
        // }
    }
}

