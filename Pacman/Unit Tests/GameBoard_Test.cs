using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    [TestFixture]
    public class GameBoard_Test
    {
        [Test]
        public void NewGameBoardTest()
        {
            GameBoard GameBoard = new GameBoard();
            // Check default Game Board image has been created
            GameBoard.CreateBoardImage(new Form1(),1);
            Assert.AreNotEqual(null, GameBoard.BoardImage.Image);
            Assert.AreEqual(0, GameBoard.BoardImage.Left);
            Assert.AreEqual(25, GameBoard.BoardImage.Top);
            Assert.AreEqual("BoardImage", GameBoard.BoardImage.Name);
        }
    }
}
