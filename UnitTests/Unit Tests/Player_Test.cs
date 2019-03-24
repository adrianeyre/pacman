using NUnit.Framework;
using System.Windows.Forms;

namespace Pacman
{
    [TestFixture]
    public class Player_Test
    {
        private Player player = new Player();

        public Player_Test()
        {
            Form form = new Form();
            player.CreatePlayerDetails(form);
            player.CreateLives(form);
        }

        [Test]
        public void NewPlayerTest()
        {
            // Check default Player
            Assert.AreEqual(0, player.Score);
            Assert.AreEqual(3, player.Lives);
        }

        [Test]
        public void CreateScoreLabelTest()
        {
            // Check default Player
            Assert.AreEqual("0", player.ScoreText.Text);
        }

        [Test]
        public void UpdateScoreTest()
        {
            // Check default Player
            player.UpdateScore(10);
            Assert.AreEqual(10, player.Score);
        }

        [Test]
        public void CreateLivesTest()
        {
            // Check default Player
            Assert.AreNotEqual(null, player.LifeImage[0]);
            Assert.AreEqual(false, player.LifeImage[5].Visible);
        }
    }
}