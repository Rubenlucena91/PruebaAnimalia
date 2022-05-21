using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTestSiluetas_peces
{
    public class Carta
    {
        public string nombre;
        public int valor;
        public Bitmap logo;
        public Carta(){}
        public Carta(string nombre, int valor, Bitmap logo)
        {
            this.nombre = nombre;
            this.valor = valor;
            this.logo = logo;
        }

    }
}
