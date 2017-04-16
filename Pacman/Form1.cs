using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        public int Level = 1;

        public Form1()
        {
            InitializeComponent();

            // Create Game Board
            GameBoard gameboard = new GameBoard();
            gameboard.CreateBoardImage(this, Level);

            // Create Pacman
            Pacman pacman = new Pacman();
            pacman.CreatePacmanImage(this);

            // Initialise Board Matrix
            gameboard.InitialiseBoardMatrix(Level);

        }
    }
}
