using System;

namespace Primera_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punto de inicio o de entrada de mi programa.

            //Tipo           Nombre         Inicialización
            DispositivoMovil miIphone = new DispositivoMovil();
            miIphone.ram = 2;
            miIphone.almacenamiento = 173;
            miIphone.resAlto = 1080;
            miIphone.resAncho = 1920;
            miIphone.color = new Color();
            miIphone.color.rojo = 100;
            miIphone.color.verde = 30;
            miIphone.color.azul = 173;

            DispositivoMovil tabletSans = new DispositivoMovil();

            tabletSans.ram = 1280;
            tabletSans.almacenamiento = 288;
            tabletSans.resAlto = 1000;
            tabletSans.resAncho = 20;
            tabletSans.color = new Color();
            tabletSans.color.rojo = 200;
            tabletSans.color.verde = 30;
            tabletSans.color.azul = 120;

            DispositivoMovil Xiaomiroto = new DispositivoMovil();
            Xiaomiroto.ram = 1;
            Xiaomiroto.almacenamiento = 20;
            Xiaomiroto.resAlto = 1200;
            Xiaomiroto.resAncho = 800;
            Xiaomiroto.color = new Color();
            Xiaomiroto.color.rojo = 230;
            Xiaomiroto.color.verde = 175;
            Xiaomiroto.color.azul = 111;



        }
    }    }