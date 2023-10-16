using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Hangman;

namespace UnitTestProject
{
    public class TestsOnAttemptSubmitted
    {
        [Fact]
        public void RemainingAttemptsAreUpdated_IsIncorrect()
        {
            //arrange
            GamePage gamePage = new("Easy");
            string word = "col";
            gamePage.Word = word;
            gamePage.AnswerEntryText = "a";

            //act
            gamePage.OnAttemptSubmitted(null, EventArgs.Empty);
            int currentAttemptsRemaining = gamePage.RemaningAttempts;
            int expectedRemainingAttempts = 6;

            //assert
            Assert.Equal(expectedRemainingAttempts, currentAttemptsRemaining);
        }

        [Fact]
        public void RemainingAttemptsAreUpdated_IsCorrect()
        {
            //arrange
            GamePage gamePage = new("Easy");
            string word = "col";
            gamePage.Word = word;
            gamePage.AnswerEntryText = "c";

            //act
            gamePage.OnAttemptSubmitted(null, EventArgs.Empty);
            int currentAttemptsRemaining = gamePage.RemaningAttempts;
            int expectedRemainingAttempts = 7;

            //assert
            Assert.Equal(expectedRemainingAttempts, currentAttemptsRemaining);
        }
    }
}
