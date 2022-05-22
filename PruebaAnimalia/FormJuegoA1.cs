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
        int timeCheck = 2;
        int timeResponder = 3;
        int puntuacion;
        int dificultad = 1;
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
            timerPartida.Start();
            countDownTime = totalTime;
            randomizarCartas();
        }

        private void restarPoints()
        {
            dificultad--;
            puntuacion = puntuacion - 150;
            lb_puntos.Text = "" + puntuacion;
        }
        private void addPoints()
        {
            dificultad++;
            puntuacion = puntuacion + 200;
            lb_puntos.Text = "" + puntuacion;
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
            int counter = 0;
            List<KeyValuePair<String, Image>> tempSombras = new List<KeyValuePair<String, Image>>(){      };
            List<KeyValuePair<String, Image>> cartas = generarCartas();
            if(dificultad > 2)
            {
                pictureBoxLeft.Enabled = true;
                pictureBoxLeft.Visible = true;
                if(dificultad > 4)
                {
                    pictureBoxRight.Enabled = true;
                    pictureBoxRight.Visible = true;
                }
                else
                {
                    pictureBoxRight.Enabled = false;
                    pictureBoxRight.Visible = false;
                }
            }
            else
            {
                pictureBoxLeft.Enabled = false;
                pictureBoxLeft.Visible = false;
                pictureBoxRight.Enabled = false;
                pictureBoxRight.Visible = false;
            }
            Console.WriteLine("Izquierda E: " + pictureBoxLeft.Enabled);
            Console.WriteLine("Izquierda V: " + pictureBoxLeft.Visible);
            Console.WriteLine("Derecha E: " + pictureBoxRight.Enabled);
            Console.WriteLine("Derecha V: " + pictureBoxRight.Visible);
            foreach (Control control in panelJuego.Controls)
            {
                PictureBox cartaPB = control as PictureBox;
                Console.WriteLine(cartaPB.Enabled);
                if (cartaPB != null && cartaPB.Enabled == true)
                {
                    int numberRandom = random.Next(cartas.Count);
                    cartaPB.Tag = "" + cartas[numberRandom].Key;
                    cartaPB.BackgroundImage = cartas[numberRandom].Value;
                    cartas.RemoveAt(numberRandom);

                    foreach (KeyValuePair<string, Image> sombra in cartasSombra)
                    {
                        if (sombra.Key.Contains(cartaPB.Tag.ToString()))
                        {
                            tempSombras.Insert(counter, new KeyValuePair<string, Image>(sombra.Key, sombra.Value));
                            break;
                        }
                    }
                    counter++;
                }   
                
            }
            int randomSombra = random.Next(tempSombras.Count);
            pictureBoxSombra.BackgroundImage = tempSombras[randomSombra].Value;
            pictureBoxSombra.Tag = "" + tempSombras[randomSombra].Key;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (timerCheck.Enabled == true)
                return;

            PictureBox clickedPB = sender as PictureBox;
            Console.WriteLine("*****************");
            Console.WriteLine(clickedPB);
            Console.WriteLine(clickedPB.Enabled);
            Console.WriteLine(clickedPB.Visible);
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
                timerImagenes.Stop();
                timerCheck.Start();
                timeCheck = 2;
                randomizarCartas();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            countDownTime--;
            labelTime.Text = "" + countDownTime;

            timeResponder--;
            labelTR.Text = "" + timeResponder;
            timeCheck--;
            labelTC.Text = "" + timeCheck;

            if (countDownTime < 1)
            {
                timerPartida.Stop();
                MessageBox.Show("You matched all the icons!", "Congratulations");
                this.Close();
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            timerCheck.Stop();
            pictureBoxResultado.BackgroundImage = null;
            timerImagenes.Start();
            timeResponder = 3;
        }
        private void timerImagenes_Tick(object sender, EventArgs e)
        {
            timerImagenes.Stop();
            pictureBoxResultado.BackgroundImage = Properties.Resources.negativo;
            randomizarCartas();
            timerCheck.Start();
            timeCheck = 2;

        }

    }
}
