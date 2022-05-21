using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTestSiluetas_peces
{
    public partial class ScreenJuegoCalculo : Form
    {
        public ScreenJuegoCalculo()
        {
            InitializeComponent();
        }
        System.Media.SoundPlayer pizarra = new System.Media.SoundPlayer(Properties.Resources.pizarra);

        private void label1_Click(object sender, EventArgs e)
        {
            pizarra.Play(); 
            lbincognita1.Text = this.Text; 
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ScreenJuegoCalculo_Load(object sender, EventArgs e)
        {
            pizarra.Play();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pizarra.Play(); 
            lbincognita1.Text = label1.Text; 
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pizarra.Play();
            lbincognita1.Text = this.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pizarra.Play();
            lbincognita1.Text = this.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pizarra.Play();
            lbincognita1.Text = this.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pizarra.Play();
            lbincognita1.Text = this.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pizarra.Play();
            lbincognita1.Text = this.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pizarra.Play();
            lbincognita1.Text = this.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            pizarra.Play();
            lbincognita1.Text = this.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pizarra.Play();
            lbincognita1.Text = this.Text;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pizarra.Play();
            lbincognita1.Text = this.Text;
        }

        private void lbincognita2_Click(object sender, EventArgs e)
        {

        }
    }
}
