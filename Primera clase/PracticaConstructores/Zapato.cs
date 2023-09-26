using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaConstructores
{
    class Zapato
    {
        private string color;
        private float talla;

        public Zapato()
        {

        }

        public Zapato(string valColar, float valTalla)
        {
            color = valColar;
            talla = valTalla;

        }

        public void describir()
        {
            Console.WriteLine("Zapatdo de color : " + color + " , de talla: " + talla);
        }
      
    }
}
