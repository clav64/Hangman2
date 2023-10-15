using Hangman;
using Hangman.Models;


namespace UnitTestProject
{
    public class TestSelectWord_v2
    {
        // Test SelectWord method, checks if return valid game word based on difficulty level
        [Fact]
        public void TestSelectWord_ReturnsWordListBasedOnLevel()
        {
            var gamePage = new GamePage("Easy");
            string selectedWord = gamePage.SelectWord("Easy");

            Assert.Contains(selectedWord, HangmanWords.EasyWords);
        }
    }
}
