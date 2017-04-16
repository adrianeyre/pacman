using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    [TestFixture]
    public class Pacman_Test
    {
        [Test]
        public void NewPacmanTest()
        {
            Pacman pacman = new Pacman();
            // Check default Pacman values
            Assert.AreEqual(0, pacman.xCoordinate);
            Assert.AreEqual(0, pacman.yCoordinate);
            Assert.AreEqual(0, pacman.score);
            Assert.AreEqual(0, pacman.currentDirection);
            Assert.AreEqual(0, pacman.nextDirection);
        }

        [Test]
        public void CreatePacmanTest()
        {
            Pacman pacman = new Pacman();
            // Check default Pacman image has been created
            pacman.CreatePacmanImage(new Form1(),0,0);
            Assert.AreNotEqual(null, pacman.PacmanImage.Image);
            Assert.AreEqual(-3, pacman.PacmanImage.Left);
            Assert.AreEqual(43, pacman.PacmanImage.Top);
            Assert.AreEqual("PacmanImage", pacman.PacmanImage.Name);
        }
    }
}
