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
        public static int counter = 0;
        public static string animalUSer ="";
        public FormUsuario()
        {
            InitializeComponent();
            if(counter == 0)
            {
               iniciarSplash();
            }
        }

        private void click(object sender, EventArgs e)
        {
            //Dependiendo de quien pulse el boton, guarda su nombre en una variable Static para que otros puedean referenciar
            var buttonClick = (Button)sender;
            animalUSer = buttonClick.Name.ToString();
            // Creamos un hilo para abrir el segundo form en STA(single thread application)
            this.Close();
            Thread thread = new Thread(openNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        // Metodo que inicia el hilo para que inicie el splash. duerme el hilo 5 segundos y termina
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
