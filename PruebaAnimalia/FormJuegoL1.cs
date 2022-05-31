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
    public partial class FormJuegoL1 : Form
    {
        int totalTime = 45;
        int countDownTime;
        int numFails = 0;
        int puntuacion = 0;
        int aciertos = 0;
        PictureBox firstClicked = null;
        PictureBox secondClicked = null;

        Random random = new Random();
        Dictionary<string, Image> imagenesGuardadas = new Dictionary<string, Image>();
        List<KeyValuePair<String, Image>> icons = new List<KeyValuePair<String, Image>>()
    {
        new KeyValuePair<String,Image>("burro", Properties.Resources.cartaBurro),new KeyValuePair<String,Image>("burro", Properties.Resources.cartaBurro),
        new KeyValuePair<String,Image>("buho",Properties.Resources.cartaBuho), new KeyValuePair<String,Image> ("buho",Properties.Resources.cartaBuho),
        new KeyValuePair<String,Image>("elefante",Properties.Resources.cartaElefante),new KeyValuePair<String,Image>("elefante",Properties.Resources.cartaElefante),
        new KeyValuePair<String,Image>("gallina",Properties.Resources.cartaGallina), new KeyValuePair<String,Image>("gallina",Properties.Resources.cartaGallina),
        new KeyValuePair<String,Image>("gato",Properties.Resources.cartaGato),new KeyValuePair<String,Image>("gato",Properties.Resources.cartaGato),
        new KeyValuePair<String,Image>("oveja",Properties.Resources.cartaOveja), new KeyValuePair<String,Image>("oveja",Properties.Resources.cartaOveja),
        new KeyValuePair<String,Image>("panda",Properties.Resources.cartaPanda), new KeyValuePair<String,Image>("panda",Properties.Resources.cartaPanda),
        new KeyValuePair<String,Image>("zorro",Properties.Resources.cartaZorro), new KeyValuePair<String,Image>("zorro",Properties.Resources.cartaZorro),
    };
        public FormJuegoL1()
        {
            InitializeComponent();
            timerPartida.Start();
            countDownTime = totalTime;
            asignarImanges();
        }

        private void asignarImanges()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                PictureBox iconPB = control as PictureBox;
                if (iconPB != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconPB.Tag = "invisible " + icons[randomNumber].Key;
                    imagenesGuardadas.Add(iconPB.Name, icons[randomNumber].Value);
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private Image seleccionarImagenCorrespondiente(PictureBox selecionado)
        {
            foreach (KeyValuePair<string, Image> kvp in imagenesGuardadas)
            {
                if (selecionado.Name == kvp.Key)
                {
                    selecionado.Tag = selecionado.Tag.ToString().Remove(0, 2);
                    return kvp.Value;
                }
            }
            return null;
        }

        private void borrarImagenCorrespondiente(PictureBox selecionado)
        {
            foreach (KeyValuePair<string, Image> kvp in imagenesGuardadas)
            {
                if (selecionado.Name == kvp.Key)
                {
                    selecionado.Tag = "in" + selecionado.Tag;
                    selecionado.BackgroundImage = null;
                }
            }
        }

        private bool comprobarIguales(PictureBox seleccionado1, PictureBox seleccionado2)
        {
            foreach (KeyValuePair<string, Image> kvp in imagenesGuardadas)
            {
                Console.WriteLine("comparacion: " + kvp.Value.ToString());
                Console.WriteLine("comparacion: " + seleccionado1.BackgroundImage.ToString());
                Console.WriteLine("comparacion: " + seleccionado2.BackgroundImage.ToString());
                if (seleccionado1.BackgroundImage == kvp.Value && seleccionado2.BackgroundImage == kvp.Value)
                {
                    Console.WriteLine("HE ACERTADO ");
                    return true;
                }
            }
            return false;
        }

        private void addPuntuacion()
        {
            if (aciertos < 2)
            {
                puntuacion = puntuacion + 200;
            }
            else if (aciertos >= 2 && aciertos <= 4)
            {
                puntuacion = puntuacion + 150;
            }
            else if (aciertos > 4 && aciertos <= 6)
            {
                puntuacion = puntuacion + 100;
            }
            else
            {
                puntuacion = puntuacion + 75;
            }
            aciertos++;
            lb_puntos.Text = "" + puntuacion;
        }

        private void restarPuntuacion()
        {

            if (numFails == 0) { }
            else if ((numFails >= 2 && numFails <= 3) || aciertos < 1)
            {
                puntuacion = puntuacion - 25;
            }
            else if (numFails > 3 && numFails <= 6)
            {
                puntuacion = puntuacion - 75;
            }
            else
            {
                puntuacion = puntuacion - 150;
            }
            lb_puntos.Text = "" + puntuacion;
            numFails++;
        }

        private int recuperarPuntuacionMaxima()
        {
            if (FormUsuario.animalUSer.Equals("bear"))
            {
                return int.Parse(Properties.Settings.Default.bear_max_score_l_1);
            }
            else if (FormUsuario.animalUSer.Equals("dog"))
            {
                return int.Parse(Properties.Settings.Default.dog_max_score_l_1);
            }
            else
            {
                return int.Parse(Properties.Settings.Default.giraffe_max_score_l_1);
            }
        }

        private void guardarPuntuaciones()
        {
            if (FormUsuario.animalUSer.Equals("bear"))
            {
                Properties.Settings.Default.bear_max_score_l_1 = lb_puntos.Text;
                Properties.Settings.Default.Save();
            }
            else if (FormUsuario.animalUSer.Equals("dog"))
            {
                Properties.Settings.Default.dog_max_score_l_1 = lb_puntos.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.giraffe_max_score_l_1 = lb_puntos.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void Victoria(){
            puntuacion = puntuacion + (countDownTime * 10);
            lb_puntos.Text = "" + puntuacion;
        }
        private void comprobarVictoria()
        {
            if(aciertos == 8)
            {
                Victoria();
                int puntuacionMaxima = recuperarPuntuacionMaxima();
                if (puntuacion > puntuacionMaxima)
                {
                    guardarPuntuaciones();
                }
                timerPartida.Stop();
                MessageBox.Show("VICTORIA!!", "Tiempo restante: " + countDownTime);
                this.Close();
            }
        }
        private void image_Click(object sender, EventArgs e)
        {
            pictureBoxResultado.BackgroundImage = null;
            if (timer1.Enabled == true)
                return;
            PictureBox clickedPB = sender as PictureBox;
            if (clickedPB != null)
            {
                if (!clickedPB.Tag.ToString().Contains("invisible"))
                {
                    return;
                }
                if (firstClicked == null)
                {
                    firstClicked = clickedPB;
                    firstClicked.BackgroundImage = seleccionarImagenCorrespondiente(firstClicked);
                    return;
                }
                secondClicked = clickedPB;
                secondClicked.BackgroundImage = seleccionarImagenCorrespondiente(secondClicked);
                if (firstClicked.Tag.ToString() == secondClicked.Tag.ToString())
                {
                    firstClicked = null;
                    secondClicked = null;
                    addPuntuacion();
                    pictureBoxResultado.BackgroundImage = Properties.Resources.positivo;
                    comprobarVictoria();
                    return;
                }
                restarPuntuacion();
                pictureBoxResultado.BackgroundImage = Properties.Resources.negativo;
                timer1.Start();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            countDownTime--;
            labelTime.Text = "" + countDownTime;
            if (countDownTime < 1)
            {
                timerPartida.Stop();
                if (pictureBoxResultado!= null)
                {
                    MessageBox.Show("Has perdido!!!", "Vuelve a intentarlo");
                }

                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            labelFallos.Text = "" + numFails;
            borrarImagenCorrespondiente(firstClicked);
            borrarImagenCorrespondiente(secondClicked);
            //pictureBoxResultado.BackgroundImage = null;
            firstClicked = null;
            secondClicked = null;
        }


        private void FormJuegoL1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerPartida.Stop();
            timer1.Stop();
        }
    }
}