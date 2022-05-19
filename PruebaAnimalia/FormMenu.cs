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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            cargarFotoPuntuacionUsuario();
        }

        private void cargarFotoPuntuacionUsuario()
        {
            if (FormUsuario.animalUSer.Equals("bear"))
            {
                pictureBox1.BackgroundImage = Properties.Resources.animalia_usuario;
                labelScoreM1.Text = Properties.Settings.Default.bear_max_score_c_1;
            }
            else if (FormUsuario.animalUSer.Equals("dog")){
                pictureBox1.BackgroundImage = Properties.Resources.animalia_usuario2;
                labelScoreM1.Text = Properties.Settings.Default.dog_max_score_c_1;
            }
            else
            {
                pictureBox1.BackgroundImage = Properties.Resources.animalia_usuario4;
                labelScoreM1.Text = Properties.Settings.Default.giraffe_max_score_c_1;
            }
            
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void cargarPuntuacionUsuario()
        {

        }
        private void buttonAgudeza_Click(object sender, EventArgs e)
        {
            panelAgudeza.Visible = true;
            panelMemoria.Visible = false;
            panelLogica.Visible = false;
            panelPercepcion.Visible = false;
        }

        private void buttonCalculo_Click(object sender, EventArgs e)
        {
            panelAgudeza.Visible = false;
            panelMemoria.Visible = true;
            panelLogica.Visible = false;
            panelPercepcion.Visible = false;
        }

        private void buttonLogica_Click(object sender, EventArgs e)
        {
            panelAgudeza.Visible = false;
            panelMemoria.Visible = false;
            panelLogica.Visible = true;
            panelPercepcion.Visible = false;
        }

        private void buttonPercepcion_Click(object sender, EventArgs e)
        {
            panelAgudeza.Visible = false;
            panelMemoria.Visible = false;
            panelLogica.Visible = false;
            panelPercepcion.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Creamos un hilo para abrir el segundo form en STA(single thread application)
            this.Close();
            Thread thread = new Thread(openNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openNewForm(object obj)
        {
            Application.Run(new FormJuegoM1());
        }

    }
}
