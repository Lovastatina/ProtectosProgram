using System;

namespace Carreradecoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto ferrari= new Auto();
            ferrari.mod = "Ferrari F1";
            ferrari.vel = 220;   //   Km/hr
            ferrari.color = new Color();
            ferrari.color.rojo = 123;
            ferrari.color.azul = 69;
            ferrari.color.verde = 111;


            Auto camaro = new Auto();
            camaro.mod = "Camaro '68";
            camaro.vel = 120;    //   Km/hr
            camaro.color = new Color();
            camaro.color.rojo = 83;
            camaro.color.azul = 19;
            camaro.color.verde = 34;

            Pista_de_carrera_hotweels pista1 = new Pista_de_carrera_hotweels();
            pista1.name = "Pista terreneitor";
            pista1.longinos = 8.2f; //  Km

            ferrari.ponergaz(2);
            ferrari.Mascuandoarranquen();
            ferrari.Acelerar(30);
            ferrari.Frenos();

            camaro.ponergaz(23);
            camaro.Mascuandoarranquen();



            

            pista1.Competir(ferrari, camaro);
            //Para que el programa continue
            Console.ReadLine();

        }
    }
}


