
namespace Guess_The_Number.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Player_Constructor_Initializes_Properties_Correctly()
        {

        //      protected Player(string name)
        // {
        //     Name = name;
        //     LastGuess = 0;
        //     Guesses = new List<int>();
        // }
            // Arrange
            string playerName = "Marcos";

            // Act
            Player player = new TestPlayer(playerName);

            // Assert
            Assert.AreEqual(playerName, player.Name); // 
            Assert.AreEqual(0, player.LastGuess);
            Assert.IsNotNull(player.Guesses);
            Assert.AreEqual(0, player.Guesses.Count);
        }

        [TestMethod]
        public void Player_GetLastGuess_Returns_Last_Guess()
        {
            // Arrange
            string playerName = "Marcos";
            int expectedGuess = 5;
            Player player = new TestPlayer(playerName);
            player.LastGuess = expectedGuess;

            // Act
            int actualGuess = player.GetLastGuess();

            // Assert
            Assert.AreEqual(expectedGuess, actualGuess);
        }

        [TestMethod]
        public void Player_ResetLastGuess_Resets_Last_Guess()
        {
            // Arrange
            string playerName = "Marcos";
            int initialGuess = 5;
            Player player = new TestPlayer(playerName);
            player.LastGuess = initialGuess;

            // Act
            player.ResetLastGuess();

            // Assert
            Assert.AreEqual(0, player.LastGuess);
        }

        // Clase de prueba de Player para poder instanciar y hacer el test
        private class TestPlayer : Player
        {
            public TestPlayer(string name) : base(name)
            {
            }

            public override void MakeGuess()
            {
                
            }
        }
    }
}
