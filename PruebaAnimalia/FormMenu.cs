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
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            // Creamos un hilo para abrir el segundo form en STA(single thread application)
            this.Close();
            Thread thread = new Thread(openNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openNewForm(object obj)
        {
            Application.Run(new FormMenuJuegos());
        }

        private void buttonPartida_Click(object sender, EventArgs e)
        {
            mostrarJuegoAlAzar();
        }
        private void mostrarJuegoAlAzar()
        {
            Random random = new Random();
            int randomNumber = random.Next(5);
            if (randomNumber == 1)
            {
                FormJuegoL1 juegoForm = new FormJuegoL1();
                juegoForm.ShowDialog();
            }
            else if(randomNumber == 2)
            {
                FormJuegoA1 juegoForm = new FormJuegoA1();
                juegoForm.ShowDialog();
            }
            else if (randomNumber == 3)
            {
                FormJuegoM1 juegoForm = new FormJuegoM1();
                juegoForm.ShowDialog();
            }
            else if (randomNumber == 4)
            {
                ScreenGlobos juegoForm = new ScreenGlobos();
                juegoForm.ShowDialog();
            }
            else if (randomNumber == 5)
            {
                PantallaJuegoSombras juegoForm = new PantallaJuegoSombras();
                juegoForm.ShowDialog();
            }
        }

    }
}
