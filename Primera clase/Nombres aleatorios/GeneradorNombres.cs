using System;
using System.Collections.Generic;
using System.Text;

namespace Nombres_aleatorios
{
    public class GeneradorNombres
    {

        public string[] numTelefonos = {
            "El doctor", "El soldado", "El jinete", "El profesor", "El payaso",
            "El maníaco", "La peste","La rata", "El obispo", "El vampiro"
        };

        public string[] numTarjetas = {
            " come", " golpea", " destroza", " mata", " aplasta",
            " devora", " destaza", " vomita", " roba", " abraza"
        };

        public string[] numNacimientos = {
            " hígados.", " cachorros.", " desayunos.", " franceses.", " ardillas."," huérfanos.",
            " huesos.", " zapatos.", " panistas.", " cerebros.", " almas.", " activistas ambientales."
        };

      

        public void generarNombre(int numMese, int numTele, int numTarj)
        {
            Console.WriteLine("Arma tu nombre de villano.");
            Console.WriteLine("");
            Console.WriteLine("Primer dígito del código de seguridad de tu tarjeta bancaria.");
            for (int e = 0; e < numTelefonos.Length; e++)
            {
                Console.WriteLine(e + ") " + numTelefonos[e]);

            }

            Console.WriteLine("");
            Console.WriteLine("Último dígito de tu número de teléfono:");
            for (int e = 0; e < numTarjetas.Length; e++)
            {
                Console.WriteLine(e + ") " + numTarjetas[e]);

            }


            Console.WriteLine("");
            Console.WriteLine("Tu mes de nacimiento:");
            for (int i = 0; i < numNacimientos.Length; i++)
            {
                Console.WriteLine(i + 1 + ") " + numNacimientos[i]);

            }

            Console.WriteLine("");
            Console.WriteLine("Tu nombre de villano es: ");
            Console.WriteLine(numTelefonos[numTele] + numTarjetas[numTarj] +  numNacimientos[numMese - 1]);

        }
    }
}
