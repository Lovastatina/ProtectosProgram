using System;

namespace Nombres_aleatorios
{
    class Nombres
    {
        public static void Main(string[] args)
        {
            GeneradorNombres Villano = new GeneradorNombres();
            Villano.numTel = 3;
            Villano.numTar = 4;
            Villano.numMes = 1;


            Villano.generarNombre();

            Console.Read();

        }
    }
}
