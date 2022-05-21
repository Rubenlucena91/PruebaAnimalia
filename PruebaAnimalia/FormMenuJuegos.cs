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
    public partial class FormMenuJuegos : Form
    {
        public FormMenuJuegos()
        {
            InitializeComponent();
            cargarFotoPuntuacionUsuario();
        }

        private void cargarFotoPuntuacionUsuario()
        {
            if (FormUsuario.animalUSer.Equals("bear"))
            {
                pictureBoxUsuario.BackgroundImage = Properties.Resources.animalia_usuario;
                labelScoreM1.Text = Properties.Settings.Default.bear_max_score_m_1;
                labelScoreP1.Text = Properties.Settings.Default.bear_max_score_l_1;
            }
            else if (FormUsuario.animalUSer.Equals("dog")){
                pictureBoxUsuario.BackgroundImage = Properties.Resources.animalia_usuario2;
                labelScoreM1.Text = Properties.Settings.Default.dog_max_score_m_1;
                labelScoreP1.Text = Properties.Settings.Default.dog_max_score_l_1;
            }
            else
            {
                pictureBoxUsuario.BackgroundImage = Properties.Resources.animalia_usuario4;
                labelScoreM1.Text = Properties.Settings.Default.giraffe_max_score_m_1;
                labelScoreP1.Text = Properties.Settings.Default.giraffe_max_score_l_1;
                
            }
            
        }

        private void buttonAgudeza_Click(object sender, EventArgs e)
        {
            panelAgudeza.Visible = true;
            panelMemoria.Visible = false;
            panelLogica.Visible = false;
            panelPercepcion.Visible = false;
            panelTop.BackColor = Color.FromArgb(198, 202, 210);
            panelBottom.BackColor = Color.FromArgb(198, 202, 210);
            pictureBoxUsuario.BackColor = Color.FromArgb(225, 214, 195);

        }

        private void buttonCalculo_Click(object sender, EventArgs e)
        {
            panelAgudeza.Visible = false;
            panelMemoria.Visible = true;
            panelLogica.Visible = false;
            panelPercepcion.Visible = false;
            panelTop.BackColor = Color.FromArgb(225, 214, 195);
            panelBottom.BackColor = Color.FromArgb(225, 214, 195);
            pictureBoxUsuario.BackColor = Color.FromArgb(198, 202, 210);
        }

        private void buttonLogica_Click(object sender, EventArgs e)
        {
            panelAgudeza.Visible = false;
            panelMemoria.Visible = false;
            panelLogica.Visible = true;
            panelPercepcion.Visible = false;
            panelTop.BackColor = Color.FromArgb(198, 202, 210);
            panelBottom.BackColor = Color.FromArgb(198, 202, 210);
            pictureBoxUsuario.BackColor = Color.FromArgb(225, 214, 195);
        }

        private void buttonPercepcion_Click(object sender, EventArgs e)
        {
            panelAgudeza.Visible = false;
            panelMemoria.Visible = false;
            panelLogica.Visible = false;
            panelPercepcion.Visible = true;
            panelTop.BackColor = Color.FromArgb(225, 214, 195);
            panelBottom.BackColor = Color.FromArgb(225, 214, 195);
            pictureBoxUsuario.BackColor = Color.FromArgb(198, 202, 210);

        }

        private void abrirJuegoAgudeza1(object sender, EventArgs e)
        {
            // Creamos un hilo para abrir el form en STA(single thread application)
            this.Close();
            Thread thread = new Thread(openFormJuegoA1);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void abrirJuegoMemoria1(object sender, EventArgs e)
        {
            // Creamos un hilo para abrir el form en STA(single thread application)
            this.Close();
            Thread thread = new Thread(openFormJuegoM1);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void abrirJuegoLogica1(object sender, EventArgs e)
        {
            // Creamos un hilo para abrir el form en STA(single thread application)
            this.Close();
            Thread thread = new Thread(openFormJuegoL1);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void abrirJuegoPercepcion1(object sender, EventArgs e)
        {
            // Creamos un hilo para abrir el form en STA(single thread application)
            this.Close();
            Thread thread = new Thread(openFormJuegoP1);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openFormJuegoM1(object obj)
        {
            Application.Run(new FormJuegoM1());
        }

        private void openFormJuegoL1(object obj)
        {
            Application.Run(new FormJuegoL1());
        }
        private void openFormJuegoA1(object obj)
        {
            Application.Run(new FormJuegoA1());
        }
        private void openFormJuegoP1(object obj)
        {
            Application.Run(new FormJuegoP1());
        }

    }
}
