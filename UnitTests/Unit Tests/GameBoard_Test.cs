using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace Pacman
{
    [TestFixture]
    public class GameBoard_Test
    {
        private GameBoard GameBoard = new GameBoard();

        [Test]
        public void NewGameBoardTest()
        {
            // Check default Game Board image has been created
            GameBoard.CreateBoardImage(new Form(),1);
            Assert.AreNotEqual(null, GameBoard.BoardImage.Image);
            Assert.AreEqual(0, GameBoard.BoardImage.Left);
            Assert.AreEqual(50, GameBoard.BoardImage.Top);
            Assert.AreEqual("BoardImage", GameBoard.BoardImage.Name);
        }

        [Test]
        public void GameBoardMatrixTest()
        {
            // Check Board Matrix for start position
            Assert.AreEqual(new Tuple<int,int> (9,17), GameBoard.InitialiseBoardMatrix(1));
        }
    }
}
