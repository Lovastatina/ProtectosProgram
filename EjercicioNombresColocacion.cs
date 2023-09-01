/*
En este ejercicio practicarás el nombre de las cosas
y su ubicación dentro del código.
Por cada línea que tenga una declaración de namespace,
clase, método, atributo, parámetro, variable, así como 
en ciclos y bloques condicionales, deberás indicar con un comentario 
qué es lo que se está declarando y dentro de qué bloque está.

No copies y pegues, debes transcribir.
NO: class Elefante
SI: clase Elefante

Observa con atención los primeros ejemplos.
*/

using System;//El using no es una declaración

namespace Ejemplos//Declaración de espacio de nombres Ejemplos
{
    class Elefante//Declaración de clase Elefante dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Elefante
        public int Edad; // Decalaración de atributo Edad dentro de la clase Elefante
        public float Peso; // Decalaración de atributo Peso dentro de la clase Elefante

        //Declaración de método Comer dentro de clase Elefante
        //Declaración de parámetro comida dentro de método comer
        public void Comer(string comida)
        {
            
            for(int i = 0; i < 10; i++)//Ciclo for dentro de método Comer
            {
                int porcionesComidas = i + 1;//Declaración de variable local porcionesComidas dentro de ciclo for
            }
            Console.WriteLine($"{Nombre} está comiendo {comida}.");//Esta línea no llevará comentario
        }


        //Declaración de método Rugir dentro de la clase Elefante
        public void Rugir()
        {
            int distanciaEscuchante = 100; //Declaración de variable locar distanciaEscuchante dentro de método Rugir

            Console.WriteLine($"{Nombre} está rugiendo.");
        }

        //Declaración de método Dormir dentro de la clase Elefante
        //Declaración de parámetro horas dentro de método Dormir
        public void Dormir(int horas)
        {
            if(horas > 10) //Bloque condicional if dentro de método Dormir
            {
                float energiaGanada = 15; //Declaración de variable local energiaGanada dentro de condicional if
            }
            Console.WriteLine($"{Nombre} está durmiendo durante {horas} horas.");
        }
    }


    class Zapatero // Declaración de clase Zapatero dentro de namespace Ejemplos
    {
        public string Nombre; //Declaracion de atributo Nombre dentro de la clase Zapatero
        public string Especialidad; //Declaracion de atributo Especialidad dentro de la clase Zapatero
        public int AniosExperiencia; //Declaracion de atributo AniosExperiencia dentro de la clase Zapatero

        //Declaración de metodo RepararZapatos dentro de la clase Zapatero
        //Declaración de parámetros tipo y cantidad dentro del método RepararZapatos
        public void RepararZapatos(string tipo, int cantidad)
        {
            int precio = 50; //Declaración de variable local precio dentro de método RepararZapatos
            if (tipo == "tenis") //Bloque condicional if dentro de método RepararZapatos
            {
                precio = 100;//Uso de variable local precio dentro de condicional if
            }
            Console.WriteLine($"{Nombre} está reparando {cantidad} zapatos de tipo {tipo} a precio {precio}");
        }

        //Declaración de metodo CrearZapato dentro de la clase Zapatero
        //Declaración de parámetros estilo y material dentro del método CrearZapato
        public void CrearZapato(string estilo, string material)
        {
            for(int i = 0; i < 100; i++)//Ciclo for dentro de método CrearZapato
            {
                if(estilo == "industrial")//Bloque condicional if dentro de ciclo for
                {
                    Console.WriteLine("Golpeando fuerte");
                }
                else//Bloque condicional else dentro de ciclo for
                {
                    Console.WriteLine("Golpeando normal");

                }
            }
            Console.WriteLine($"{Nombre} está creando un zapato de estilo {estilo} con material {material}.");
        }

        //Declaración de metodo MedirPie dentro de la clase Zapatero
        //Declaración de parametro numeroPie dentro de metodo numeroPie
        public void MedirPie(int numeroPie)
        {
            string cliente;//Declaracion de variable local cliente dentro del metodo MedirPier
            if (numeroPie > 20) //Bloque condicional if dentro del metodo MedirPie
            {
                cliente = "Adulto";//Uso de variable local cliente dentro de bloque condicional if
            }
            else//Bloque condicional else dentro del metodo MedirPie
            {
                cliente = "Niño"; //Uso de variable local cliente dentro de bloque condicional else
            }
            Console.WriteLine($"{Nombre} está midiendo el pie para el número {numeroPie}.");
        }
    }

    //Declaración de clase Television dentro de namespace Ejemplo
    class Television
    {
        public string Marca; //Declaracion de atribuo Marca dentro de clase Television
        public int Pulgadas; //Declaracion de atribuo Pulgadas dentro de clase Television
        public bool Encendida; //Declaracion de atribuo Encendida dentro de clase Television

        //Declaración de método Encender dentro de clase Television
        public void Encender()
        {
            Encendida = true; //Uso de variable Encendida dentro de metodo Encender
            float consumoLuz = 0.05f; //Declaracion de variable particular consumoLuz dentro de metodo Encender
            Console.WriteLine($"La televisión de {Pulgadas} pulgadas, marca {Marca}, está encendida.");
        }

        //Declaración de método CambiarCanal dentro de clase Television
        //Declaración de parametro canal dentro de metodo CambiarCanal
        public void CambiarCanal(int canal)
        {
            for(int i = 1; i < canal; i++)//Ciclo for dentro de metodo CambiarCanal
            {
                Console.WriteLine($"Cambiando a canal {i}.");
            }            
        }

        //Declaración de método AjustarVolumen dentro de clase Television
        //Declaración de parametro nivel dentro de metodo AjustarVolumen
        public void AjustarVolumen(int nivel)
        {
            if (nivel > 100)//Bloque condicional if dentro de metodo AjustarVolumen
            {
                nivel = 0;//Uso de variable nivel dentro condicional if
            }
            Console.WriteLine($"Ajustando el volumen a nivel {nivel}.");
        }
    }

    //Declaracion de clase Guitarra dentro de namespace Ejemplos
    class Guitarra
    {
        public string Marca;//Declaracion de atributo Marca dentro de clase Guitarra
        public string Tipo;//Declaracion de atributo Tipo dentro de clase Guitarra
        public int Cuerdas;//Declaracion de atributo Cuerdas dentro de clase Guitarra

        //Declaracion de metodo TocarCuerda dentro de clase Guitarra
        //Declaracion de parametro numeroCuerda dentro de metodo TocarCuerda
        public void TocarCuerda(int numeroCuerda)
        {
            if(numeroCuerda == 6)//Bloque condicional if dentro de metodo TocarCuerda
            {
                string nota = "Mi"; //Declaracion de variable local nota dentro de condicional if
            }
            else if (numeroCuerda == 5) //Bloque condicional els if dentro de metodo TocarCuerda
            {
                string nota = "La"; //Declaracion de variable local nota dentro de condicional else if
            }
            Console.WriteLine($"Tocando la cuerda {numeroCuerda} de la guitarra {Marca}.");
        }

        //Declaracion de metodo AfinarGuitarra dentro de clase Guitarra
        //Declaracion de parametro afinada dentro de Metodo AfinarGuitarra
        public void AfinarGuitarra(bool afinada)
        {
            if (afinada) //Bloque condicional if dentro de metodo AfinarGuitarra
            {
                Console.WriteLine($"La guitarra {Marca} está afinada.");
            }
            else //Bloque condicional else dentro de metodo AfinarGuiatarra
            {
                for(int i = 0; i < 5; i++) //Cilo for dentro de condicional else
                {
                    Console.WriteLine($"Afinando la guitarra {Marca}.");
                }                
            }
        }

        //Declaracion de metodo CambiarTipo dentro de clase Guitarra
        //Declaracion de parametro nuevoTipo dentro de cmetodo CambiarTipo
        public void CambiarTipo(string nuevoTipo)
        {
            Tipo = nuevoTipo; //Uso de variable tipo dentro de metodo Cambiartipo
            Console.WriteLine($"Cambiando el tipo de la guitarra a {nuevoTipo}.");
        }
    }

}
