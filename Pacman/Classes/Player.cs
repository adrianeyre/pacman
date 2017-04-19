using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    class Player
    {
        public int Score = 0;
        public Label ScoreText = new Label();

        public void CreatePlayerDetails(Form formInstance)
        {
            // Create Score label
            ScoreText.Text = Score.ToString();
            ScoreText.ForeColor = System.Drawing.Color.White;
            ScoreText.Font = new System.Drawing.Font("Folio XBd BT", 14);
            ScoreText.Top = 23;
            ScoreText.Left = 30;
            ScoreText.Height = 20;
            ScoreText.Width = 100;
            formInstance.Controls.Add(ScoreText);
            ScoreText.BringToFront();
        }
    }
}
