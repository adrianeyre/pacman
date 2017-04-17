using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    [TestFixture]
    public class Ghost_Test
    {

        [Test]
        public void NewGhostTest()
        {
            // Check default Food image has been created
            Ghost Ghost = new Ghost();

            //Assert.AreNotEqual(null, Food.FoodImage[1, 1].Image);
            //Assert.AreEqual("FoodImage0", Food.FoodImage[1, 1].Name);
        }
    }
}
