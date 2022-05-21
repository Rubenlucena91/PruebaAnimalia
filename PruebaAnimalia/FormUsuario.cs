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
    public partial class FormUsuario : Form
    {
        public static string animalUSer ="";
        public FormUsuario()
        {
            InitializeComponent();
            iniciarSplash();
            //MessageBox.Show("Cada usuario guarda sus propias puntuaciones", "Selecciona tu usuario");
        }

        private void click(object sender, EventArgs e)
        {
            var buttonClick = (Button)sender;
            animalUSer = buttonClick.Name.ToString();
            // Creamos un hilo para abrir el segundo form en STA(single thread application)
            this.Close();
            Thread thread = new Thread(openNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void iniciarSplash()
        {
            Thread thread = new Thread(new ThreadStart(startSplashForm));
            thread.Start();
            Thread.Sleep(5000);
            thread.Abort();
        }

        private void startSplashForm()
        {
            Application.Run(new FormSplash());
        }

        private void openNewForm(object obj)
        {
            Application.Run(new FormMenu());
        }

    }
}
