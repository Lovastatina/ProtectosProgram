using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaConstructores
{
    class Persona
    {
        private int anoNaciscta;

        public Persona()
        {

        }

        public Persona(int valAnio)
        {
            anoNaciscta = valAnio;
        }

        public void describir()
        {
            Console.WriteLine("Persona: " + anoNaciscta );
        }
        public int obtEdad()
        {
            
            int edad = 2023 - anoNaciscta;
            return edad;

        }
    }
}
