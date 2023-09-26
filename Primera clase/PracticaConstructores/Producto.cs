using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaConstructores
{
    class Producto
    {
        private float precio;

        public Producto()
        {

        }

        public Producto(float valPrecio)
        {
            precio = valPrecio;
        }

        public void describir()
        {
            Console.WriteLine("Producto " + precio + "$");
        }
        public float obtPrecioConIVA()
        {
            float iva = precio * 0.16f;
            float precioFinal = precio + iva;
            return precioFinal;

        }
    }
}
