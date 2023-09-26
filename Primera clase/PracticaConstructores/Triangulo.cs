using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaConstructores
{
    public class Triangulo
    {
        private float primLado;
        private float segLado;
        private float terLado;

        public Triangulo()
        {

        }
        public Triangulo(float lad1, float lad2, float lad3)
        {
            primLado = lad1;
            segLado = lad2;
            terLado = lad3;

        }

        public void describir()
        {
            Console.WriteLine("Triángulo " + primLado + "x" + segLado + "x" + terLado);
        }

        public float calcPeri()
        {
            float perime = primLado + segLado +terLado;
            return perime;
        }


    }
}

