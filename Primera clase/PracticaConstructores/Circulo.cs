using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaConstructores
{
    public class Circulo
    {
        private float radio = 5;


        public Circulo()
        {

        }
        public Circulo(float valorRadio)
        {
            radio = valorRadio;
        }

        public void describir()
        {
            Console.WriteLine("Círculo " + radio + "x 2 x pi");
        }

        public float calcPeri()
        {
            float perimetro = radio * 2 * 3.1416f;
            return perimetro;
        }


    }
}
