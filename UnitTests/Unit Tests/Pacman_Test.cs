using NUnit.Framework;
using System.Windows.Forms;

namespace Pacman
{
    [TestFixture]
    public class Pacman_Test
    {
        private Pacman pacman = new Pacman();

        [Test]
        public void NewPacmanTest()
        {
            // Check default Pacman values
            Assert.AreEqual(0, pacman.xCoordinate);
            Assert.AreEqual(0, pacman.yCoordinate);
            Assert.AreEqual(0, pacman.currentDirection);
            Assert.AreEqual(0, pacman.nextDirection);
        }

        [Test]
        public void CreatePacmanTest()
        {
            // Check default Pacman image has been created
            pacman.CreatePacmanImage(new Form(),0,0);
            Assert.AreNotEqual(null, pacman.PacmanImage.Image);
            Assert.AreEqual(-3, pacman.PacmanImage.Left);
            Assert.AreEqual(43, pacman.PacmanImage.Top);
            Assert.AreEqual("PacmanImage", pacman.PacmanImage.Name);
        }
    }
}
