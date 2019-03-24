using NUnit.Framework;

namespace Pacman
{
    [TestFixture]
    public class Food_Test
    {
        public Food Food = new Food();

        public Food_Test()
        {
            Food.CreateFoodImages(new Form1());
        }

        [Test]
        public void NewFoodTest()
        {
            // Check default Food image has been created
            Assert.AreNotEqual(null, Food.FoodImage[1, 1].Image);
            Assert.AreEqual("FoodImage0", Food.FoodImage[1, 1].Name);
        }

        [Test]
        public void AmountOfFoodTest()
        {
            // Check amount of food
            Assert.AreEqual(240, Food.Amount);
        }

        [Test]
        public void EatFoodTest()
        {
            // Eat food
            Food.EatFood(1, 1);
            Assert.AreEqual(false, Food.FoodImage[1, 1].Visible);
        }
    }
}
