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

namespace PruebaTestSiluetas_peces
{
    public partial class ScreenStartSombras : Form
    {
        public ScreenStartSombras()
        {
            InitializeComponent();
        }

        int numeroClick;
        Boolean goRight = false;
        int backLeft = 8;
        PantallaJuegoSombras f2 = new PantallaJuegoSombras();
        Form3 f3 = new Form3();




        private void Form1_Load(object sender, EventArgs e)
        {
            numeroClick = 1; 
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            f2.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f3.Show();
        }
    }
}
