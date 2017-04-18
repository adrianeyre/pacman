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
    class Ghost
    {
        public int Amount = -1;
        public ImageList GhostImages = new ImageList();
        public PictureBox[] GhostImage = new PictureBox[4];
        
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

            GhostImages.ImageSize = new Size(27, 28);
        }

        public void CreateGhostImage(Form formInstance)
        {
            // Create Ghost Image
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 27; x++)
                {
                    if (Form1.gameboard.Matrix[y, x] == 15)
                    {
                        Amount++;
                        GhostImage[Amount] = new PictureBox();
                        GhostImage[Amount].Name = "GhostImage" + Amount.ToString();
                        GhostImage[Amount].SizeMode = PictureBoxSizeMode.AutoSize;
                        GhostImage[Amount].Location = new Point(x * 16 - 3, y * 16 + 43);
                        GhostImage[Amount].Image = GhostImages.Images[Amount * 4];
                        formInstance.Controls.Add(GhostImage[Amount]);
                        GhostImage[Amount].BringToFront();
                    }
                }
            }
        }
    }
}
