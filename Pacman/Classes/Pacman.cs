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

        public void CreatePacmanImage(Form formInstance)
        {
            // Create Pacman Image
            PacmanImage.Name = "PacmanImage";
            PacmanImage.SizeMode = PictureBoxSizeMode.AutoSize;
            PacmanImage.Location = new Point(0, 0);
            PacmanImage.Image = Properties.Resources.Pacman_2_1;
            formInstance.Controls.Add(PacmanImage);
            PacmanImage.BringToFront();
        }
    }
}
