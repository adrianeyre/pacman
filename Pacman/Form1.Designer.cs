namespace Pacman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OneUPLabel = new System.Windows.Forms.TextBox();
            this.HighScoreLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OneUPLabel
            // 
            this.OneUPLabel.BackColor = System.Drawing.Color.Black;
            this.OneUPLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OneUPLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OneUPLabel.Enabled = false;
            this.OneUPLabel.Font = new System.Drawing.Font("Folio XBd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneUPLabel.ForeColor = System.Drawing.Color.White;
            this.OneUPLabel.Location = new System.Drawing.Point(37, 0);
            this.OneUPLabel.Name = "OneUPLabel";
            this.OneUPLabel.Size = new System.Drawing.Size(71, 23);
            this.OneUPLabel.TabIndex = 100;
            this.OneUPLabel.TabStop = false;
            this.OneUPLabel.Text = "1 UP";
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.BackColor = System.Drawing.Color.Black;
            this.HighScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HighScoreLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HighScoreLabel.Enabled = false;
            this.HighScoreLabel.Font = new System.Drawing.Font("Folio XBd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreLabel.ForeColor = System.Drawing.Color.White;
            this.HighScoreLabel.Location = new System.Drawing.Point(2, 0);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(447, 23);
            this.HighScoreLabel.TabIndex = 101;
            this.HighScoreLabel.TabStop = false;
            this.HighScoreLabel.Text = "HIGH SCORE";
            this.HighScoreLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(449, 581);
            this.Controls.Add(this.OneUPLabel);
            this.Controls.Add(this.HighScoreLabel);
            this.Name = "Form1";
            this.Text = "Pacman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OneUPLabel;
        private System.Windows.Forms.TextBox HighScoreLabel;
    }
}

