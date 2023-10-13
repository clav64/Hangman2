using Xunit;
using Hangman;

namespace UnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string word =  "testing";

            GamePage gamepage = new GamePage(word);
            char trueTestLetter = 't';
            char falseTestLetter = 'z';
            var resultFalse = gamepage.CheckLetterInWord(word, falseTestLetter);
            var resultTrue = gamepage.CheckLetterInWord(word, trueTestLetter);

            Assert.True(resultTrue);
            Assert.False(resultFalse);

        }

    }
}