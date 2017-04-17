using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    [TestFixture]
    public class Food_Test
    {
        [Test]
        public void NewFoodTest()
        {
            Food Food = new Food();
            Food.CreateFoodImages(new Form1());
            // Check default Food image has been created
            Assert.AreNotEqual(null, Food.FoodImage[1, 1].Image);
            Assert.AreEqual("FoodImage0", Food.FoodImage[1, 1].Name);
        }
    }
}
