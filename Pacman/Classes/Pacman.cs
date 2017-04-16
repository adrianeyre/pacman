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
        public int currentDirection = 0;
        public int nextDirection = 0;
        public PictureBox PacmanImage = new PictureBox();
        public Timer timer = new Timer();

        public Pacman()
        {
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }

        public void CreatePacmanImage(Form formInstance, int StartXCoordinate, int StartYCoordinate)
        {
            // Create Pacman Image
            xCoordinate = StartXCoordinate;
            yCoordinate = StartYCoordinate;
            PacmanImage.Name = "PacmanImage";
            PacmanImage.SizeMode = PictureBoxSizeMode.AutoSize;
            PacmanImage.Location = new Point(StartXCoordinate * 16 - 3, StartYCoordinate * 16 + 43);
            PacmanImage.Image = Properties.Resources.Pacman_2_1;
            formInstance.Controls.Add(PacmanImage);
            PacmanImage.BringToFront();
        }

        public void MovePacman(int direction)
        {
            // Move Pacman
            bool CanMove = check_direction(nextDirection);
            if (!CanMove) { CanMove = check_direction(currentDirection); direction = currentDirection; } else { direction = nextDirection; }
            if (CanMove) { currentDirection = direction; }

            if (CanMove)
            {
                switch (direction)
                {
                    case 1: PacmanImage.Top -= 16; yCoordinate--; break;
                    case 2: PacmanImage.Left += 16; xCoordinate++; break;
                    case 3: PacmanImage.Top += 16; yCoordinate++; break;
                    case 4: PacmanImage.Left -= 16; xCoordinate--; break;
                }
                currentDirection = direction;
            }
        }

        private bool check_direction(int direction)
        {
            // Check if pacman can move to space
            switch (direction)
            {
                case 1: return direction_ok(xCoordinate, yCoordinate - 1);
                case 2: return direction_ok(xCoordinate + 1, yCoordinate);
                case 3: return direction_ok(xCoordinate, yCoordinate + 1);
                case 4: return direction_ok(xCoordinate - 1, yCoordinate);
                default: return false;
            }
        }

        private bool direction_ok(int x, int y)
        {
            // Check if board space can be used
            if (Form1.gameboard.Matrix[y, x] < 4) { return true; } else { return false; }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Keep moving pacman
            MovePacman(currentDirection);
        }
    }
}
