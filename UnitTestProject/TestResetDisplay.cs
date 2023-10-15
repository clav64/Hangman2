using Hangman;

namespace UnitTestProject
{
    public class TestResetDisplay
    {
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
    }
}
