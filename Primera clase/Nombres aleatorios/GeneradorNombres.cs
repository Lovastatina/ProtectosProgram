using System;
using System.Collections.Generic;
using System.Text;

namespace Nombres_aleatorios
{
    public class GeneradorNombres
    {
        public string[] numNam = { "El doctor", "El soldado", "El jinete", "El profesor", "El payaso" };

        public string[] numTelefono = { " como intestinos.", " golpea cachorros.", " destroza desayunos.", " mata franceses.", " aplasta ardillas" };

        public string final;

        public int numMes = 2;
        public int numTel = 3;

        public void Generar()
        {
            for (int i = 0; i < numNam.Length; i++)
            {
                Console.WriteLine(i + 1 + ".- " + numNam[i]);
               
            }

            for (int e = 0; e < numTelefono.Length; e++)
            {
                Console.WriteLine(e + 1 + ".- " + numNam[e]);
               
            }


            Console.WriteLine("Tu nombre de villano es " + numNam[numMes] + numTelefono[numTel]);




        }



    }

}
