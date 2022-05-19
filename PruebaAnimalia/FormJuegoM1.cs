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
    public partial class FormJuegoM1 : Form
    {
        bool desaparecer = false;
        int totalTime = 10;
        int countDownTime;
        int dificultad = 2;
        int contador = 0;
        int puntuacion;
        int segundoPausado;
        string fraseMaquina;
        public FormJuegoM1()
        {
            InitializeComponent();
            timerPartida.Start();
            countDownTime = totalTime;
            nuevoNumero();
            cadenaMaquina();
        }

        private void nuevoNumero()
        {
            Random random = new Random();
            string listaChar = "0123456789#";
            string aleatorio = "";
            for (int i = 0; i < dificultad; i++)
            {
                int randomIndex = random.Next(listaChar.Length);
                aleatorio = aleatorio + listaChar[randomIndex];
            }
            fraseMaquina = aleatorio;
        }

        private string numeroAdivinar(string numero)
        {
            return "" + numero[contador];
        }

        private void jugar(object sender, EventArgs e)
        {
            var numeroClick = (PictureBox)sender;
            string numeroClickado = numeroClick.Tag.ToString();
            label1.Text = label1.Text + numeroClickado;
            aciertoFalloNumero(numeroClickado); 
            lb_puntos.Text = puntuacion.ToString();
            if(contador == fraseMaquina.Length)
            {
                dificultad++;
                contador = 0;
                nuevoNumero();
                cadenaMaquina();
                label1.Text = "";
            }
        }

        private void aciertoFalloNumero(string numeroClickado)
        {
            if (numeroClickado.Equals(numeroAdivinar(fraseMaquina)))
            {
                pictureBoxRespuesta.BackgroundImage = Properties.Resources.positivo;
                pictureBoxRespuesta.BackgroundImageLayout = ImageLayout.Stretch;
                puntuacion = puntuacion + 2;
                contador++;
            }
            else
            {
                pictureBoxRespuesta.BackgroundImage = Properties.Resources.negativo;
                pictureBoxRespuesta.BackgroundImageLayout = ImageLayout.Stretch;
                if(puntuacion >= 3) { puntuacion--; }
                contador = 0;
                nuevoNumero();
                cadenaMaquina();
                label1.Text = "";
            }
        }



        private void cadenaMaquina()
        {
            label2.Text = fraseMaquina;
            string tiempo = labelTime.Text;
            desaparecer = true;
            segundoPausado = int.Parse(labelTime.Text);
        }

        private int recuperarPuntuacionMaxima()
        {
            if (FormUsuario.animalUSer.Equals("bear"))
            {
                return int.Parse(Properties.Settings.Default.bear_max_score_c_1);
            }
            else if (FormUsuario.animalUSer.Equals("dog"))
            {
                return int.Parse(Properties.Settings.Default.dog_max_score_c_1);
            }
            else
            {
               return  int.Parse(Properties.Settings.Default.giraffe_max_score_c_1);
            }
        }
        private void guardarPuntuaciones()
        {
            if (FormUsuario.animalUSer.Equals("bear"))
            {
                Properties.Settings.Default.bear_max_score_c_1 = lb_puntos.Text;
                Properties.Settings.Default.Save();
            }
            else if (FormUsuario.animalUSer.Equals("dog"))
            {
                Properties.Settings.Default.dog_max_score_c_1 = lb_puntos.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.giraffe_max_score_c_1 = lb_puntos.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            if (desaparecer)
            {
                Console.WriteLine("estoy fuera");
                Console.WriteLine("tiempo " + segundoPausado +" - " + (countDownTime + 2));
                if (segundoPausado == (countDownTime + 1))
                {
                    Console.WriteLine("estoy dentro");
                    label2.Text = "";
                    desaparecer = false;
                }
            }
            countDownTime--;
            labelTime.Text = "" + countDownTime;
            if (countDownTime < 1)
            { 
                int puntuacionMaxima = recuperarPuntuacionMaxima();
                Console.WriteLine("puntuacion Actual: " + puntuacion +" - " + puntuacionMaxima);
                if (puntuacion > puntuacionMaxima)
                {
                    Console.WriteLine("puntuacion Guardada");
                    guardarPuntuaciones();
                }
                timerPartida.Stop();
                pictureBoxRespuesta.Visible = false;
                this.Close();
            }
            
        }
    }
}
