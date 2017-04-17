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
        public const int Amount = 4;
        public ImageList GhostImages = new ImageList();
        public PictureBox[] GhostImage = new PictureBox[Amount];
        
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
        }

        public void CreateGhostImage(Form formInstance)
        {
            // Create Ghost Image
            for (int x=0; x<Amount; x++)
            {
                GhostImage[x] = new PictureBox();
                GhostImage[x].Name = "GhostImage" + x.ToString();
                GhostImage[x].SizeMode = PictureBoxSizeMode.AutoSize;
                GhostImage[x].Location = new Point(x * 40 + 50, x * 40 + 50);
                GhostImage[x].Image = Properties.Resources.Ghost_0_1;
                formInstance.Controls.Add(GhostImage[x]);
                GhostImage[x].BringToFront();
            }
        }
    }
}
