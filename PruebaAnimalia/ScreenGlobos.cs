using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PruebaAnimalia
{
    public partial class ScreenGlobos : Form

    {
        int speed;
        int score;
        Random random = new Random();
        bool gameOver;
        System.Media.SoundPlayer popglobo = new System.Media.SoundPlayer(Properties.Resources.popballoon);
        System.Media.SoundPlayer boom = new System.Media.SoundPlayer(Properties.Resources.popbomb);
        public ScreenGlobos()
        {
            InitializeComponent();
            Restart(); 
        }

        private void PrincipalTimer_Tick(object sender, EventArgs e)
        {

            label1.Text = "Score: " + score;

            if (gameOver == true)
            {
                gameTimer.Stop();
                label1.Text = "Score: " + score + " Game over, press enter to restart!";
            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    x.Top -= speed;

                    if (x.Top < -100)
                    {
                        x.Top = random.Next(700, 1000);
                        x.Left = random.Next(5, 400);
                    }

                    if ((string)x.Tag == "balloon")
                    {

                        if (x.Top < -50)
                        {
                            gameOver = true;
                        }

                        if (globonegro.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = random.Next(700, 1000);
                            x.Left = random.Next(5, 400);
                        }
                    }
                }

            }


            if (score > 5)
            {
                speed = 8;
            }

            if (score > 15 && score < 25)
            {
                speed = 12;
            }

        }


        private void popBalloon(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                popglobo.Play();  
                var baloon = (PictureBox)sender; 

                baloon.Top = random.Next(700, 1000); 

                baloon.Left = random.Next(5, 400); 

                score++; 
            }
        }



         private void popBlack(object sender, EventArgs e)
        {
            {
                if (gameOver == false)
                {
                    boom.Play(); 
                    globonegro.Image = Properties.Resources.boom; 
                    gameTimer.Stop(); // stop the timer
                    label1.Text += "  Game Over! -  Press Enter to retry"; 
                    gameOver = true; 
                }
            }
        }

        private void ScreenGlobos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gameOver==true)  
            {
                Restart(); 
            }
        }

        private void Restart() {
            speed = 5;
            score = 0;
            gameOver = false;

            globonegro.Image = Properties.Resources.globonegro;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Top = random.Next(750, 1000);
                    x.Left = random.Next(5, 400);
                }
            }

            gameTimer.Start();
        }
    }
}
