using System;

namespace Practica2
{
    class Practicaz
    {
        static void Main(string[] args)
        {
            string[] ciudades = { "Osaka", "Montevideo", "Seúl", "Tecamachalco", "El Paso", "Lima" };

            int cantElems = ciudades.Length;
            Console.WriteLine("El arreglo tiene " + cantElems + " elementos.");

            string ciudad1 = ciudades[0];
            string ciudad4 = ciudades[4];

            Console.WriteLine(ciudad1);
            Console.WriteLine(ciudades[1]);
            Console.WriteLine(ciudades[2]);
            Console.WriteLine(ciudades[3]);
            Console.WriteLine(ciudades[4]);
            Console.WriteLine(ciudades[5]);

            ciudades[4] = "Cacalotepec";

            Console.WriteLine("La nueva ciudad cinco es " + ciudades[4]);

            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.WriteLine(i+1 + ".- " + ciudades[i]);




            }





            Console.Read();

        }
    }
}
