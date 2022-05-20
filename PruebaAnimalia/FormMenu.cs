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

        private void click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormJuegoM2 juegoForm = new FormJuegoM2();
            juegoForm.ShowDialog();
        }

    }
}
