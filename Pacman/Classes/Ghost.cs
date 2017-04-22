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
    public class Ghost
    {
        private const int GhostAmount = 4;

        public int Ghosts = GhostAmount;
        private ImageList GhostImages = new ImageList();
        public PictureBox[] GhostImage = new PictureBox[GhostAmount];
        public int[] State = new int[GhostAmount];
        private Timer timer = new Timer();
        private Timer killabletimer = new Timer();
        private Timer statetimer = new Timer();
        private Timer hometimer = new Timer();
        public int[] xCoordinate = new int[GhostAmount];
        public int[] yCoordinate = new int[GhostAmount];
        private int[] xStart = new int[GhostAmount];
        private int[] yStart = new int[GhostAmount];
        public int[] Direction = new int[GhostAmount];
        private Random ran = new Random();
        private bool GhostOn = false;

        public Ghost()
        {
            GhostImages.Images.Add(Properties.Resources.Ghost_0_1);
            GhostImages.Images.Add(Properties.Resources.Ghost_0_2);
            GhostImages.Images.Add(Properties.Resources.Ghost_0_3);
            GhostImages.Images.Add(Properties.Resources.Ghost_0_4);

            GhostImages.Images.Add(Properties.Resources.Ghost_1_1);
            GhostImages.Images.Add(Properties.Resources.Ghost_1_2);
            GhostImages.Images.Add(Properties.Resources.Ghost_1_3);
            GhostImages.Images.Add(Properties.Resources.Ghost_1_4);

            GhostImages.Images.Add(Properties.Resources.Ghost_2_1);
            GhostImages.Images.Add(Properties.Resources.Ghost_2_2);
            GhostImages.Images.Add(Properties.Resources.Ghost_2_3);
            GhostImages.Images.Add(Properties.Resources.Ghost_2_4);

            GhostImages.Images.Add(Properties.Resources.Ghost_3_1);
            GhostImages.Images.Add(Properties.Resources.Ghost_3_2);
            GhostImages.Images.Add(Properties.Resources.Ghost_3_3);
            GhostImages.Images.Add(Properties.Resources.Ghost_3_4);

            GhostImages.Images.Add(Properties.Resources.Ghost_4);
            GhostImages.Images.Add(Properties.Resources.Ghost_5);

            GhostImages.ImageSize = new Size(27, 28);

            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);

            killabletimer.Interval = 200;
            killabletimer.Enabled = false;
            killabletimer.Tick += new EventHandler(killabletimer_Tick);

            statetimer.Interval = 10000;
            statetimer.Enabled = false;
            statetimer.Tick += new EventHandler(statetimer_Tick);

            hometimer.Interval = 5;
            hometimer.Enabled = false;
            hometimer.Tick += new EventHandler(hometimer_Tick);
        }

        public void CreateGhostImage(Form formInstance)
        {
            // Create Ghost Image
            for (int x=0; x<Ghosts; x++)
            {
                GhostImage[x] = new PictureBox();
                GhostImage[x].Name = "GhostImage" + x.ToString();
                GhostImage[x].SizeMode = PictureBoxSizeMode.AutoSize;
                formInstance.Controls.Add(GhostImage[x]);
                GhostImage[x].BringToFront();
            }
            Set_Ghosts();
            ResetGhosts();
        }

        public void Set_Ghosts()
        {
            // Find Ghost locations
            int Amount = -1;
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 27; x++)
                {
                    if (Form1.gameboard.Matrix[y, x] == 15)
                    {
                        Amount++;
                        xStart[Amount] = x;
                        yStart[Amount] = y;
                    }
                }
            }
        }

        public void ResetGhosts()
        {
            // Reset Ghost States
            for (int x=0; x<GhostAmount; x++)
            {
                xCoordinate[x] = xStart[x];
                yCoordinate[x] = yStart[x];
                GhostImage[x].Location = new Point(xStart[x] * 16 - 3, yStart[x] * 16 + 43);
                GhostImage[x].Image = GhostImages.Images[x * 4];
                Direction[x] = 0;
                State[x] = 0;
            }
        }

        private void statetimer_Tick(object sender, EventArgs e)
        {
            // Turn Ghosts back
            for (int x=0; x<GhostAmount; x++)
            {
                State[x] = 0;
            }
            statetimer.Enabled = false;
            //killabletimer.Enabled = false;
        }

        private void hometimer_Tick(object sender, EventArgs e)
        {
            // Move ghosts to their home positions
            for (int x=0; x<GhostAmount; x++)
            {
                if (State[x] == 2)
                {
                    int xpos = xStart[x] * 16 - 3;
                    int ypos = yStart[x] * 16 + 43;
                    if (GhostImage[x].Left > xpos) { GhostImage[x].Left--; }
                    if (GhostImage[x].Left < xpos) { GhostImage[x].Left++; }
                    if (GhostImage[x].Top  > ypos) { GhostImage[x].Top--; }
                    if (GhostImage[x].Top < ypos) { GhostImage[x].Top++; }
                    if (GhostImage[x].Top == ypos && GhostImage[x].Left == xpos)
                    {
                        State[x] = 0;
                        xCoordinate[x] = xStart[x];
                        yCoordinate[x] = yStart[x];
                        GhostImage[x].Left = xStart[x] * 16 - 3;
                        GhostImage[x].Top = yStart[x] * 16 + 43;
                    }
                } 
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Keep moving the ghosts
            for (int x = 0; x < Ghosts; x++)
            {
                if (State[x] > 0) { continue; }
                MoveGhosts(x);
            }
            GhostOn = !GhostOn;
            CheckForPacman();
        }

        private void killabletimer_Tick(object sender, EventArgs e)
        {
            // Keep moving the ghosts
            for (int x = 0; x < Ghosts; x++)
            {
                if (State[x] != 1) { continue; }
                MoveGhosts(x);
            }
        }

        private void MoveGhosts(int x)
        {
            // Move the ghosts
            if (Direction[x] == 0)
            {
                if (ran.Next(0, 5) == 3) { Direction[x] = 1;}
            }
            else
            {
                bool CanMove = false;
                Other_Direction(Direction[x], x);

                while (!CanMove)
                {
                    CanMove = check_direction(Direction[x], x);
                    if (!CanMove) { Change_Direction(Direction[x], x); }

                }

                if (CanMove)
                {
                    switch (Direction[x])
                    {
                        case 1: GhostImage[x].Top -= 16; yCoordinate[x]--; break;
                        case 2: GhostImage[x].Left += 16; xCoordinate[x]++; break;
                        case 3: GhostImage[x].Top += 16; yCoordinate[x]++; break;
                        case 4: GhostImage[x].Left -= 16; xCoordinate[x]--; break;
                    }
                    switch (State[x])
                    {
                        case 0: GhostImage[x].Image = GhostImages.Images[x * 4 + (Direction[x] - 1)]; break;
                        case 1:
                            if (GhostOn) { GhostImage[x].Image = GhostImages.Images[17];} else { GhostImage[x].Image = GhostImages.Images[16]; };
                            break;
                        case 2: GhostImage[x].Image = GhostImages.Images[18]; break;
                    }
                }
            }
            
        }

        private bool check_direction(int direction, int ghost)
        {
            // Check if ghost can move to space
            switch (direction)
            {
                case 1: return direction_ok(xCoordinate[ghost], yCoordinate[ghost] - 1, ghost);
                case 2: return direction_ok(xCoordinate[ghost] + 1, yCoordinate[ghost], ghost);
                case 3: return direction_ok(xCoordinate[ghost], yCoordinate[ghost] + 1, ghost);
                case 4: return direction_ok(xCoordinate[ghost] - 1, yCoordinate[ghost], ghost);
                default: return false;
            }
        }

        private bool direction_ok(int x, int y, int ghost)
        {
            // Check if board space can be used
            if (x < 0) { xCoordinate[ghost] = 27; GhostImage[ghost].Left = 429; return true; }
            if (x > 27) { xCoordinate[ghost] = 0; GhostImage[ghost].Left = -5; return true; }
            if (Form1.gameboard.Matrix[y, x] < 4 || Form1.gameboard.Matrix[y, x] > 10) { return true; } else { return false; }
        }

        private void Change_Direction(int direction, int ghost)
        {
            // Change the direction of the ghost
            int which = ran.Next(0, 2);
            switch (direction)
            {
                case 1: case 3: if (which == 1) { Direction[ghost] = 2; } else { Direction[ghost] = 4; }; break;
                case 2: case 4: if (which == 1) { Direction[ghost] = 1; } else { Direction[ghost] = 3; }; break;
            }
        }

        private void Other_Direction(int direction, int ghost)
        {
            // Check to see if the ghost can move a different direction
            if (Form1.gameboard.Matrix[yCoordinate[ghost], xCoordinate[ghost]] < 4)
            {
                bool[] directions = new bool[5];
                int x = xCoordinate[ghost];
                int y = yCoordinate[ghost];
                switch (direction)
                {
                    case 1: case 3: directions[2] = direction_ok(x + 1, y, ghost); directions[4] = direction_ok(x - 1, y, ghost); break;
                    case 2: case 4: directions[1] = direction_ok(x, y - 1, ghost); directions[3] = direction_ok(x, y + 1, ghost); break;
                }
                int which = ran.Next(0, 5);
                if (directions[which] == true) { Direction[ghost] = which; }
            }
        }

        public void ChangeGhostState()
        {
            // Change the state off all of the ghosts so that they can be eaten
            for (int x=0; x<GhostAmount; x++)
            {
                if (State[x] == 0)
                {
                    State[x] = 1;
                    GhostImage[x].Image = GhostImages.Images[16];
                }
            }
            killabletimer.Stop();
            killabletimer.Enabled = true;
            killabletimer.Start();
            statetimer.Stop();
            statetimer.Enabled = true;
            statetimer.Start();
        }

        public void CheckForPacman()
        {
            // Check to see if a ghost is on the same block as Pacman
            for (int x = 0; x < GhostAmount; x++)
            {
                if (xCoordinate[x] == Form1.pacman.xCoordinate && yCoordinate[x] == Form1.pacman.yCoordinate)
                {
                    switch (State[x])
                    {
                        case 0: Form1.player.LoseLife(); break;
                        case 1:
                            State[x] = 2;
                            hometimer.Enabled = true;
                            GhostImage[x].Image = Properties.Resources.eyes;
                            Form1.player.UpdateScore(300);
                            break;
                    }
                }
            }
        }
    }
}
