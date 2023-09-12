using System;
using System.Collections.Generic;
using System.Text;

namespace Nombres_aleatorios
{
    public class GeneradorNombres
    {

        public string[] numTelefono = {
            "El doctor", "El soldado", "El jinete", "El profesor", "El payaso",
            "El maníaco", "La peste","La rata", "El obispo", "El vampiro"
        };

        public string[] numTarjeta = {
            " come", " golpea", " destroza", " mata", " aplasta",
            " devora", " destaza", " vomita", " roba", " abraza"
        };

        public string[] numNam = {
            " hígados.", " cachorros.", " desayunos.", " franceses.", " ardillas."," huérfanos.",
            " huesos.", " zapatos.", " panistas.", " cerebros.", " almas.", " activistas ambientales."
        };

        public int numMes;
        public int numTel;
        public int numTar;

        public void generarNombre()
        {
            Console.WriteLine("Arma tu nombre de villano.");
            Console.WriteLine("");
            Console.WriteLine("Primer dígito del código de seguridad de tu tarjeta bancaria.");
            for (int e = 0; e < numTelefono.Length; e++)
            {
                Console.WriteLine(e + ") " + numTelefono[e]);

            }

            Console.WriteLine("");
            Console.WriteLine("Último dígito de tu número de teléfono:");
            for (int e = 0; e < numTarjeta.Length; e++)
            {
                Console.WriteLine(e + ") " + numTarjeta[e]);

            }


            Console.WriteLine("");
            Console.WriteLine("Tu mes de nacimiento:");
            for (int i = 0; i < numNam.Length; i++)
            {
                Console.WriteLine(i + 1 + ") " + numNam[i]);

            }

            Console.WriteLine("");
            Console.WriteLine("Tu nombre de villano es: ");
            Console.WriteLine(numTelefono[numTel] + numTarjeta[numTar] +  numNam[numMes - 1]);

        }
    }
}
