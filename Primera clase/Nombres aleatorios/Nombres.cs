using System;

namespace Nombres_aleatorios
{
    class Nombres
    {
        public static void Main(string[] args)
        {
            GeneradorNombres Villano = new GeneradorNombres();
         
            Villano.generarNombre(1,2,6);

            Console.Read();

        }
    }
}
