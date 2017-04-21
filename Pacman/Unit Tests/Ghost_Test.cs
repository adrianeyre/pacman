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
    public class Ghost_Test
    {
        private Ghost Ghost = new Ghost();

        public Ghost_Test()
        {
            Ghost.CreateGhostImage(new Form());
        }

        [Test]
        public void NewGhostTest()
        {
            // Check default Ghost image has been created
            Assert.AreNotEqual(null, Ghost.GhostImage[0].Image);
        }
    }
}
