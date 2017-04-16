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
    class Pacman
    {
        public int xCoordinate = 0;
        public int yCoordinate = 0;
        public int score = 0;
        public PictureBox PacmanImage = new PictureBox();

        public Pacman()
        {

        }

        public void CreatePacmanImage(Form formInstance, int StartXCoordinate, int StartYCoordinate)
        {
            // Create Pacman Image
            int x = StartXCoordinate * 16 - 3;
            int y = StartYCoordinate * 16 + 43;
            PacmanImage.Name = "PacmanImage";
            PacmanImage.SizeMode = PictureBoxSizeMode.AutoSize;
            PacmanImage.Location = new Point(x, y);
            PacmanImage.Image = Properties.Resources.Pacman_2_1;
            formInstance.Controls.Add(PacmanImage);
            PacmanImage.BringToFront();
        }
    }
}
