using Xunit;
using Hangman;
using Hangman.Models;

namespace UnitTestProject
{
    public class TestsCheckLetterInWord
    {
        [Fact]
        public void TestForLowerCase()
        {
            GamePage gamepage = new("Easy");

            string word = "testing";
            char trueTestLetter = 't';
            char falseTestLetter = 'z';
            var resultFalse = gamepage.CheckLetterInWord(word, falseTestLetter);
            var resultTrue = gamepage.CheckLetterInWord(word, trueTestLetter);

            Assert.True(resultTrue);
            Assert.False(resultFalse);
        }
        [Fact]
        public void TestForUpperCase()
        {
            GamePage gamepage = new("Easy");

            string word = "testing";
            char trueTestLetter = 'T';
            char falseTestLetter = 'Z';
            var resultFalse = gamepage.CheckLetterInWord(word, falseTestLetter);
            var resultTrue = gamepage.CheckLetterInWord(word, trueTestLetter);

            Assert.True(resultTrue);
            Assert.False(resultFalse);
        }

        // Test SelectWord method, checks if return valid game word based on difficulty level
        [Fact]
        public void TestSelectWord_ReturnsWordListBasedOnLevel()
        {
            var gamePage = new GamePage("Easy");
            string selectedWord = gamePage.SelectWord("Easy");

            Assert.Contains(selectedWord, HangmanWords.EasyWords);
        }

        // Test ResetDisplay method, checks if labels are set correctly 
        [Fact]
        public void TestResetDisplay_ReturnsChangedLabel()
        {
            var gamePage = new GamePage("Easy");
            gamePage.ResetDisplay("apple");

            Label letter1 = gamePage.FindByName<Label>("Letter1");
            Label letter2 = gamePage.FindByName<Label>("Letter2");


            Assert.Equal("a", letter1.Text);
            Assert.Equal("p", letter2.Text);
        }


        public class AnotherTest
        {
            [Fact]
            public void Test()
            {

            }
        }
    }
}