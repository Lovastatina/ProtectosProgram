using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaConstructores
{
    class Email
    {
        private string sub;
        private string cont;
        private string dest;


        public Email()
        {

        }

        public Email(string texSub, string texCont, string textDest)
        {
            sub = texSub;
            cont = texCont;
            dest = textDest;
        }

        public void leer()
        {
            Console.WriteLine("Tu email es: " + sub + ", con destitario: " + dest + " .El Email dice:" + cont);
        }
        
    }
}
