using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hangman;
using NuGet.Frameworks;

namespace UnitTestProject
{
   
    public class TestSelectedWord
    {

        [Fact]
        public void Test_Easy_Test_Selected_Word()
        {
            List<string> Words = new List<string> { "apple", "car", "float" };

            GamePage gp = new GamePage();

            string word = gp.SelectWord("Easy");

            Assert.Contains(word, Words);   
            
        }

        [Fact]
        public void Test_Medium_Test_Selected_Word()
        {
            List<string> Words = new List<string> { "bananas", "flopper", "streaker" };

            GamePage gp = new GamePage();

            string word = gp.SelectWord("Medium");

            Assert.Contains(word, Words);

        }

        [Fact]
        public void Test_Hard_Test_Selected_Word()
        {
            List<string> Words = new List<string> { "establishment", "frictionless", "distinguish" };

            GamePage gp = new GamePage();

            string word = gp.SelectWord("Hard");

            Assert.Contains(word, Words);

        }

    }
}
