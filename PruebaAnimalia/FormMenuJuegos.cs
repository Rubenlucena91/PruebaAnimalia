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
            buttonVolver.BackColor = Color.FromArgb(225, 214, 195);

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
            buttonVolver.BackColor = Color.FromArgb(198, 202, 210);
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
            buttonVolver.BackColor = Color.FromArgb(225, 214, 195);
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
            buttonVolver.BackColor = Color.FromArgb(198, 202, 210);

        }

        private void abrirJuegoAgudeza1(object sender, EventArgs e)
        {
            FormJuegoA1 juegoForm = new FormJuegoA1();
            juegoForm.ShowDialog();
        }
        private void abrirJuegoMemoria1(object sender, EventArgs e)
        {
            FormJuegoM1 juegoForm = new FormJuegoM1();
            juegoForm.ShowDialog();
        }
        private void abrirJuegoLogica1(object sender, EventArgs e)
        {
            FormJuegoL1 juegoForm = new FormJuegoL1();
            juegoForm.ShowDialog();
        }
        private void abrirJuegoPercepcion1(object sender, EventArgs e)
        {
            FormJuegoP1 juegoForm = new FormJuegoP1();
            juegoForm.ShowDialog();
        }

        private void abrirJuegoGlobos(object sender, EventArgs e)
        {
            ScreenGlobos juegoForm = new ScreenGlobos();
            juegoForm.ShowDialog();
        }

        private void abrirJuegoCueva(object sender, EventArgs e)
        {
            PantallaJuegoSombras juegoForm = new PantallaJuegoSombras();
            juegoForm.ShowDialog();
        }

        private void abrirMenu(object sender, EventArgs e)
        {
            // Creamos un hilo para abrir el form en STA(single thread application)
            FormUsuario.counter = 1;
            this.Close();
            Thread thread = new Thread(openFormMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openFormMenu(object obj)
        {
            Application.Run(new FormUsuario());
        }

    }
}
