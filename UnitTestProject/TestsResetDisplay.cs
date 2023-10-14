using Xunit;
using Hangman;

namespace UnitTestProject
{
    public class TestsResetDisplay
    {
        [Fact]
        public void TestResetDisplay()
        {
            GamePage gamepage = new("Easy");
            string word = "testing";

            gamepage.ResetDisplay(word);

            for (int i = 0; i < 12; i++)
            {
                char letter = i < word.Length ? word[i] : ' ';
                Label letterLabel = gamepage.FindByName<Label>("Letter" + (i + 1));
                Assert.Equal(letter.ToString(), letterLabel.Text);
            }

        }
    }
}
