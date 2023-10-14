using Xunit;
using Hangman;

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
    }

    public class TestsForGameOver
    {
        [Fact]
        public void TestingGameOver()
        {
            GamePage gamepage = new("Easy");
            
        }
    }
}