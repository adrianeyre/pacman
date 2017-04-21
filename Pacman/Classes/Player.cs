using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pacman
{
    public class Player
    {
        private const int MaxLives = 10;
        public int Score = 0;
        public int Lives = 3;
        public Label ScoreText = new Label();
        public PictureBox[] LifeImage = new PictureBox[MaxLives];

        public void CreateLives(Form formInstance)
        {
            for(int x = 0; x < MaxLives; x++)
            {
                LifeImage[x] = new PictureBox();
                LifeImage[x].Name = "Life" + x.ToString();
                LifeImage[x].SizeMode = PictureBoxSizeMode.AutoSize;
                LifeImage[x].Location = new Point(x * 30 + 3, 550);
                LifeImage[x].Image = Properties.Resources.Life;
                formInstance.Controls.Add(LifeImage[x]);
                LifeImage[x].BringToFront();
            }
            SetLives();
        }

        public void CreatePlayerDetails(Form formInstance)
        {
            // Create Score label
            ScoreText.ForeColor = System.Drawing.Color.White;
            ScoreText.Font = new System.Drawing.Font("Folio XBd BT", 14);
            ScoreText.Top = 23;
            ScoreText.Left = 30;
            ScoreText.Height = 20;
            ScoreText.Width = 100;
            formInstance.Controls.Add(ScoreText);
            ScoreText.BringToFront();
            UpdateScore(0);
        }

        public void UpdateScore(int amount = 1)
        {
            // Update score value and text
            Score += amount;
            ScoreText.Text = Score.ToString();
            if (Score > Form1.highscore.Score) { Form1.highscore.UpdateHighScore(Score); }
        }

        public void SetLives()
        {
            // Display lives in form
            for (int x=0; x<Lives+1; x++)
            {
                LifeImage[x].Visible = true;
            }
            for (int x = Lives-1; x < MaxLives; x++)
            {
                LifeImage[x].Visible = false;
            }
        }

        public void LoseLife()
        {
            // Lose a life
            Lives--;
            if (Lives > 0)
            {
                Form1.pacman.Set_Pacman();
                Form1.ghost.ResetGhosts();
                SetLives();
            }
            else
            {
                Application.Exit();
            }
        }

        public void LevelComplete()
        {
            Application.Exit();
        }
    }
}
