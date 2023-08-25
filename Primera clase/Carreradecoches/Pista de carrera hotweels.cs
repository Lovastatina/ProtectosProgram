
using System;

namespace Carreradecoches
{
    public class Pista_de_carrera_hotweels
    {
        public float longinos;
        public string name;


    //metodo de dos           parámatros (opcional)
    

    public void Competir(Auto auto1, Auto auto2){
                                                              //concatenación
            Console.WriteLine("Iniciando competencia entre " + auto1.mod + " contra " + auto2.mod);
            if(auto1.vel > auto2.vel)
            {
                Console.WriteLine("Ganó " + auto1.mod);

            }

            else if (auto2.vel > auto1.vel)
            {
                Console.WriteLine("Ganó " + auto2.mod);

            }

            else 
            {
                Console.WriteLine("Hubo un empate");
            }



        }
    }
}
