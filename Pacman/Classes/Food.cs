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
    class Food
    {
        public PictureBox[,] FoodImage = new PictureBox[30,27];
        //public PictureBox PacmanImage = new PictureBox();

        public void CreateFoodImages(Form formInstance)
        {
            int num = 0;
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 27; x++)
                {
                    //Console.WriteLine(Form1.gameboard.Matrix[y, x]);
                    if (Form1.gameboard.Matrix[y,x] == 1)
                    {
                        FoodImage[y, x] = new PictureBox();
                        FoodImage[y, x].Name = "FoodImage" + num.ToString();
                        FoodImage[y, x].SizeMode = PictureBoxSizeMode.AutoSize;
                        FoodImage[y, x].Location = new Point(x * 16 - 1, y * 16 + 47);
                        FoodImage[y, x].Image = Properties.Resources.Block_1;
                        formInstance.Controls.Add(FoodImage[y, x]);
                        FoodImage[y, x].BringToFront();
                        num++;
                    }
                }
            }
        }
    }
}
