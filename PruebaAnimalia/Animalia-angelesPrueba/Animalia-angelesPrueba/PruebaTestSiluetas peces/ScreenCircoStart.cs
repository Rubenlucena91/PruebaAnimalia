using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTestSiluetas_peces
{
    public partial class ScreenCircoStart : Form
    {
        ScreenGlobos juegoGlobos = new ScreenGlobos(); 
        public ScreenCircoStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            juegoGlobos.Show(); 
        }
    }


}
