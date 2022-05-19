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
    public partial class FormSplash : Form
    {

        public FormSplash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Creamos un hilo para abrir el segundo form en STA(single thread application)
            this.Close();
            Thread thread = new Thread(openNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openNewForm(object obj)
        {
            Application.Run(new FormUsuario());
        }
    }
}
