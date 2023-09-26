using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaConstructores
{
    public class Rectangulo
    {
        private float ancho = 5;
        private float alto = 10;

        public Rectangulo()
        {

        }
        public Rectangulo(float valorAncho, float valorAlto)
        {
            ancho = valorAncho;
            alto = valorAlto;
        }

        public void setAncho(float anch) {
            ancho = anch;
        }

        public void setAlt(float alt)
        {
            alto = alt;
        }


        public void describir()
        {
            Console.WriteLine("Rectángulo " + ancho + "x" + alto);
        }
        public float calcArea()
        {
            float area = ancho * alto;
            return area;
        }


    }
}
