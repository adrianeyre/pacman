using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    [TestFixture]
    public class Player_Test
    {
        private Player player = new Player();

        [Test]
        public void NewPlayerTest()
        {
            // Check default Player
            Assert.AreEqual(0, player.Score);
        }

        [Test]
        public void CreateScoreLabelTest()
        {
            // Check default Player
            player.CreatePlayerDetails(new Form());
            Assert.AreEqual("0", player.ScoreText.Text);
        }

        [Test]
        public void UpdateScoreTest()
        {
            // Check default Player
            player.UpdateScore(10);
            Assert.AreEqual(10, player.Score);
        }
    }
}