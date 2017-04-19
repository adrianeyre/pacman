using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}