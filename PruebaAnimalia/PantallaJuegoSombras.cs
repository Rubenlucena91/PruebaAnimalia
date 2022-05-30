using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace PruebaAnimalia
{
    public partial class PantallaJuegoSombras : Form
    {

        int counter = 0;
        List<Carta> tempList;
        int acierto = 0;
        bool igual = false;
        Carta cartaSombra = new Carta("OsoGirl", 1, Properties.Resources._01_oso);
        Carta carta2Sombra = new Carta("OsoBoy", 2, Properties.Resources._02_oso);
        Carta carta3Sombra = new Carta("OsoKid", 3, Properties.Resources._03_oso);
        Carta carta4Sombra = new Carta("Tomato", 4, Properties.Resources._01_tomato);
        Carta carta5Sombra = new Carta("Orange", 5, Properties.Resources._02_orange);
        Carta carta6Sombra = new Carta("Raspberry", 6, Properties.Resources._03_raspberry);
        List<Carta> listaCartasSombra;
        Carta carta = new Carta("OsoGirl", 1, Properties.Resources._001_bear);
        Carta carta2 = new Carta("OsoBoy", 2, Properties.Resources._002_bear_1);
        Carta carta3 = new Carta("OsoKid", 3, Properties.Resources._003_bear_2);
        Carta carta4 = new Carta("Tomato", 4, Properties.Resources._001_tomato);
        Carta carta5 = new Carta("Orange", 5, Properties.Resources._002_orange);
        Carta carta6 = new Carta("Raspberry", 6, Properties.Resources._003_raspberry);
        List<Carta> listaCartas;
        Dictionary<Carta, Carta> listaCartaParejas = new Dictionary<Carta, Carta>();
        public PantallaJuegoSombras()
        {
            InitializeComponent();
            listaCartasSombra = new List<Carta> { cartaSombra, carta2Sombra, carta3Sombra, carta4Sombra, carta5Sombra, carta6Sombra };
            listaCartas = new List<Carta> { carta, carta2, carta3, carta4, carta5, carta6 };
            listaCartaParejas.Add(cartaSombra,carta);
            listaCartaParejas.Add(carta2Sombra, carta2);
            listaCartaParejas.Add(carta3Sombra, carta3);
            listaCartaParejas.Add(carta4Sombra, carta4);
            listaCartaParejas.Add(carta5Sombra, carta5);
            listaCartaParejas.Add(carta6Sombra, carta6);
        }
        

        private void actualizarPuntuacion()
        {
            lb_puntos.Text = acierto.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            pictureBox5.Image = Properties.Resources._001_bear;
            System.Media.SoundPlayer cueva = new System.Media.SoundPlayer(Properties.Resources.cuevadentro);
            cueva.Play();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // si es el mismo que la sombra suma un punto
            String senderTipo = "el sender es del tipo " + sender.GetType();
            String senderNombre = "el sender es del nombre " + sender.GetType().Name;
            String senderFullNombre = "el sender full del nombre " + sender.GetType().FullName;

            String eTipo = "el events es del tipo " + e.GetType();
            String eNombre = "el events es del nombre " + e.GetType().Name;
            String eFullNombre = "el events full del nombre " + e.GetType().FullName;

            String prieba = sender.ToString();
            Console.WriteLine("has clickado en: " + eTipo);
            Console.WriteLine("has clickado en1: " + senderTipo);
            Console.WriteLine("has clickado en2: " + eNombre);
            Console.WriteLine("has clickado en3: " + senderNombre);
            Console.WriteLine("has clickado en4: " + eFullNombre);
            Console.WriteLine("has clickado en5: " + senderFullNombre);
            Console.WriteLine("has clickado en: " + prieba);
            if (1 == 1)
            {
                acierto++;
            }
            // si es distinto que la sombra resta un punto
            else
            {
                acierto--;
            }
            actualizarPuntuacion();
            // cambia la sombra
            // cambia la imagen
            randomizedPictureBox2(pictureBox1, cambiarPictureBoxSombra2());
            //cambiarPictureBox(pictureBox5);
            //cambiarPictureBox(pictureBox1);
            //cambiarPictureBox(pictureBox2);
            //cambiarPictureBox(pictureBox3);

        }

        //recursiva
        private void randomizedPictureBox(PictureBox pictureBox)
        {
            if(counter == 0)
            {
                tempList = new List<Carta>(listaCartas);
            }
            counter++;
            Random random = new Random();
            int numberRandom = random.Next(0, tempList.Count);
            Console.WriteLine("Normal el numero es: " + numberRandom);
            pictureBox.Name = tempList[numberRandom ].nombre;
            pictureBox.Image = tempList[numberRandom ].logo;
            tempList.RemoveAt(numberRandom);
            switch (counter)
                {
                    case 1:
                        randomizedPictureBox(pictureBox2);
                        break;
                    case 2:
                        randomizedPictureBox(pictureBox3);
                        break;
                }
            counter = 0;
            return;
        }

        //recursiva
        private void randomizedPictureBox2(PictureBox pictureBox, Carta carta)
        {
            if (counter == 0)
            {
                tempList = new List<Carta>(listaCartas);
            }
            counter++;
            Random random = new Random();
            int numberRandom = random.Next(0, tempList.Count);
            Console.WriteLine("Normal el numero es: " + numberRandom);
            pictureBox.Name = tempList[numberRandom].nombre;
            pictureBox.Image = tempList[numberRandom].logo;
            if(carta.nombre == pictureBox.Name) { igual = true; }
            tempList.RemoveAt(numberRandom);
            switch (counter)
            {
                case 1:
                    randomizedPictureBox2(pictureBox2, carta);
                    return;
                    break;
                case 2:
                    randomizedPictureBox2(pictureBox3, carta);
                    return;
                    break;
            }
            if (!igual)
            {
                pictureBox.Name = carta.nombre;
                pictureBox.Image = carta.logo;
            }
            counter = 0;
            igual = false;
            return;
        }

        // cambiar la imagen de la sombra
        private void cambiarPictureBoxSombra()
        {
            Random random = new Random();
            int numberRandom = random.Next(1, 4);
            Console.WriteLine("Sombra el numero es: " + numberRandom);
            foreach (Carta elegida in listaCartasSombra)
            {
                if (numberRandom.Equals(elegida.valor))
                {
                    pictureBox4.Name = elegida.nombre;
                    pictureBox4.Image = elegida.logo;
                    break;
                }
            }
        }

        // cambiar la imagen de la sombra2
        private Carta cambiarPictureBoxSombra2()
        {
            Random random = new Random();
            int numberRandom = random.Next(1, 4);
            Console.WriteLine("Sombra el numero es: " + numberRandom);
            foreach (KeyValuePair<Carta, Carta> elegida in listaCartaParejas)
            {
                if (numberRandom.Equals(elegida.Key.valor))
                {
                    pictureBox4.Name = elegida.Key.nombre;
                    pictureBox4.Image = elegida.Key.logo;
                    return elegida.Value;
                }

            }
            return null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (int.Parse(labelTime.Text) != 0)
            {
                int futureText = int.Parse(labelTime.Text) - 1;
                labelTime.Text = futureText.ToString();
            }
            else
            {
                // actions when the timer ends 
                lb_puntos.Text = "GAME OVER";
            }
        }
    }
}
