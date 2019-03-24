using NUnit.Framework;
using System.Windows.Forms;

namespace Pacman
{
    class FormElements_Test
    {
       public FormElements FormElements = new FormElements();

        [Test]
        public void CreateFormElementsTest()
        {
            // Check Form Elements have been created
            FormElements.CreateFormElements(new Form());
            Assert.AreEqual("1UP", FormElements.PlayerOneScoreText.Text);
            Assert.AreEqual("HIGH SCORE", FormElements.HighScoreText.Text);
        }
    }
}
