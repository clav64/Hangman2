using Xunit;
using Hangman;

namespace UnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            GamePage gamepage = new GamePage("hello");

            string word = "hello";
            
            char testFalse = 'a';
            char testTrue = 'e';

            var resultFalse = gamepage.CheckLetterInWord(word, testFalse);
            var resultTrue = gamepage.CheckLetterInWord(word, testTrue);

            Assert.True(resultTrue);
            Assert.False(resultFalse);

        }
    }
}