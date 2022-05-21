using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaAnimalia
{
    public partial class FormJuegoA1 : Form
    {
        int totalTime = 60;
        int countDownTime;
        int posicionAnterior;
        int puntuacion;
        int counter = 1;
        Random random = new Random();

        List<KeyValuePair<String, Image>> cartasSombra = new List<KeyValuePair<String, Image>>()
    {
        new KeyValuePair<String,Image>("cabra_sombra", Properties.Resources.cabra_sombra),
        new KeyValuePair<String,Image> ("cerdo_sombra",Properties.Resources.cerdo_sombra),
        new KeyValuePair<String,Image>("lobo_sombra",Properties.Resources.lobo_sombra),
        new KeyValuePair<String,Image>("mapache_sombra",Properties.Resources.mapache_sombra),
        new KeyValuePair<String,Image>("mono_sombra",Properties.Resources.mono_sombra),
    };
        public FormJuegoA1()
        {
            InitializeComponent();
            //randomizarCartas();
            timerPartida.Start();
            countDownTime = totalTime;
        }

        private void restarPoints()
        {
            puntuacion = puntuacion - 150;
            lb_puntos.Text = "" + puntuacion;
        }
        private void addPoints()
        {
            puntuacion = puntuacion + 200;
            lb_puntos.Text = "" + puntuacion;
        }
        private int numeroAlAzar()
        {
            int numer = random.Next(3);
            return random.Next(2);
        }
        private List<KeyValuePair<String, Image>> generarCartas()
        {
            return new List<KeyValuePair<String, Image>>()
                {
                    new KeyValuePair<String,Image>("cabra", Properties.Resources.cabra),
                    new KeyValuePair<String,Image>("cerdo",Properties.Resources.cerdo),
                    new KeyValuePair<String,Image>("lobo",Properties.Resources.lobo),
                    new KeyValuePair<String,Image>("mapache",Properties.Resources.mapache),
                    new KeyValuePair<String,Image>("mono",Properties.Resources.mono),
                };
        }
        private void randomizarCartas()
        {
            int numeroComparar = numeroAlAzar();
            int randomSombra = random.Next(cartasSombra.Count);
            List<KeyValuePair<String, Image>> cartas = generarCartas();
            pictureBoxSombra.BackgroundImage = cartasSombra[randomSombra].Value;
            pictureBoxSombra.Tag = "" + cartasSombra[randomSombra].Key;
            foreach (Control control in panelJuego.Controls)
            {
                PictureBox cartaPB = control as PictureBox;
                if (cartaPB != null)
                {
                    if (counter == numeroComparar)
                    {
                        string cartaBuscar = pictureBoxSombra.Tag.ToString();
                        cartaBuscar = cartaBuscar.Remove(cartaBuscar.Length - 7);
                        for (int i = (cartas.Count -1); i == 0; i--)
                        {
                            if (cartas[i].Key.Equals(cartaBuscar))
                            {
                                cartaPB.Tag = cartas[i].Key;
                                cartaPB.BackgroundImage = cartas[i].Value;
                                cartas.RemoveAt(i);
                            }
                        }
                    }
                    else 
                    { 
                        int numberRandom = random.Next(cartas.Count);
                        cartaPB.Tag = "" + cartas[numberRandom].Key;
                        cartaPB.BackgroundImage = cartas[numberRandom].Value;
                        cartas.RemoveAt(numberRandom);
                    }
                    
                }
                counter++;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            counter = 0;
            
            PictureBox clickedPB = sender as PictureBox;
            if (clickedPB != null)
            {
                string nombreComparacion = clickedPB.Tag.ToString() + "_sombra";
                Console.WriteLine("Nombre normal mas agregacion: " + nombreComparacion);
                Console.WriteLine("Nombre Sombra: " + pictureBoxSombra.Tag.ToString());
                Console.WriteLine(nombreComparacion.Equals(pictureBoxSombra.Tag.ToString()));
                if (nombreComparacion.Equals(pictureBoxSombra.Tag.ToString()))
                {
                    addPoints();
                    pictureBoxResultado.BackgroundImage = Properties.Resources.positivo;
                }
                else
                {
                    restarPoints();
                    pictureBoxResultado.BackgroundImage = Properties.Resources.negativo;
                }

                randomizarCartas();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            countDownTime--;
            labelTime.Text = "" + countDownTime;
            if (countDownTime < 1)
            {
                timerPartida.Stop();
                MessageBox.Show("You matched all the icons!", "Congratulations");
                this.Close();
            }
        }

    }
}
