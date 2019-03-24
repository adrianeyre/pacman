using NUnit.Framework;
using System.Windows.Forms;

namespace Pacman
{
    [TestFixture]
    public class HighScore_Test
    {
        public HighScore HighScore = new HighScore();

        [Test]
        public void CreateHighScoreTest()
        {
            // Check High Score has been created
            HighScore.CreateHighScore(new Form());
            Assert.AreEqual(HighScore.InitalScore.ToString(), HighScore.HighScoreText.Text);
        }
    }
}
