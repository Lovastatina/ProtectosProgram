using System;


namespace Carreradecoches
{
    public class Auto
    {
        public string mod;
        public Color color;
        public float vel;
        public float gaz;
        
        public void Mascuandoarranquen() { 
            if (gaz > 0)
            {
                gaz = gaz - 0.1f;
                Console.WriteLine(mod + " arrancó. Le queda " + gaz + " de gasolina.");
            }

            else
            {
                gaz = 0;
                Console.WriteLine(mod + " no tiene gasolina.");
            }

                    }

        public void ponergaz(float cant)
        {
            gaz = gaz + cant;
            Console.WriteLine("Se puso gas a " + mod + ". Ahora tiene " + gaz);

        }

        public void Acelerar(float acz)
        {
            if (gaz > 0)
            {
                vel = vel + acz;
                gaz = gaz - acz / 10f;

                if (gaz > 0)
                {
                    Console.WriteLine(mod + " aceleró y aumentó su velocidad a " + vel + ". La gasolina se redujo a " + gaz + ".");
                }

                else
                {
                    vel = 0;
                    Console.WriteLine("Se acabó la gasolina. Al " + mod + " se le apagó el motor.");
                }
            }

        }

        public void Frenos ()
        {
            if (vel > 0)
            {
                vel = 0;
                Console.WriteLine(mod + " frenó de imprvisto. Evidentemente, su velocidad es " + vel+".");
            }
        }


    }
    
}