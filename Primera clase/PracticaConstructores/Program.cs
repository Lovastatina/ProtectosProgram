using System;

namespace PracticaConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo re1 = new Rectangulo();         
            re1.describir();
            float area1 = re1.calcArea();
            Console.WriteLine("Área=" + area1);

            Console.WriteLine("");

            Rectangulo re2 = new Rectangulo();
            re2.setAlt(8f);
            re2.setAncho(13f);
            re2.describir();
            float area2 = re2.calcArea();
            Console.WriteLine("Área=" + area2);

            Console.WriteLine("");

            Rectangulo re3 = new Rectangulo(34f, 28f);
            re3.describir();
            float area3 = re3.calcArea();
            Console.WriteLine("Área=" + area3);

            Console.WriteLine("");
            Console.WriteLine("");

            Circulo ci1 = new Circulo(23f);
            ci1.describir();
            float perimetro1 = ci1.calcPeri();
            Console.WriteLine("Perímetro=" + perimetro1);

            Console.WriteLine("");

            Circulo ci2 = new Circulo(34f);
            ci2.describir();
            float perimetro2 = ci2.calcPeri();
            Console.WriteLine("Perímetro=" + perimetro2);

            Console.WriteLine("");
            Console.WriteLine("");

            Triangulo tri1 = new Triangulo(23f,34f,13f);
            tri1.describir();
            float peri1 = tri1.calcPeri();
            Console.WriteLine("Perímetro=" + peri1);

            
            Console.WriteLine("");

            Triangulo tri2 = new Triangulo(2f, 4f, 3f);
            tri2.describir();
            float peri2 = tri2.calcPeri();
            Console.WriteLine("Perímetro=" + peri2);

            Console.WriteLine("");
            Console.WriteLine("");

            Producto prod1 = new Producto(234f);
            prod1.describir();
            float precio1 = prod1.obtPrecioConIVA();
            Console.WriteLine("Precio final: " + precio1);

            Console.WriteLine("");

            Producto prod2 = new Producto(654f);
            prod2.describir();
            float precio2 = prod2.obtPrecioConIVA();
            Console.WriteLine("Precio final: " + precio2);

            Console.WriteLine("");
            Console.WriteLine("");

            Persona per1 = new Persona(2004);
            per1.describir();
            float edad1 = per1.obtEdad();
            Console.WriteLine("Edad: " + edad1);

            Console.WriteLine("");

            Persona per2 = new Persona(2012);
            per2.describir();
            float edad2 = per2.obtEdad();
            Console.WriteLine("Edad: " + edad2);

            Console.WriteLine("");
            Console.WriteLine("");

            Zapato zap1 = new Zapato("Negro", 5f);
            zap1.describir();

            Console.WriteLine("");

            Zapato zap2 = new Zapato("Morada", 2f);
            zap2.describir();

            Console.WriteLine("");
            Console.WriteLine("");

            Email em1 = new Email("Reclamo", "Quiero hacer un reclamo.", "Ramiro Ramirez");
            em1.leer();

            Console.WriteLine("");

            Email em2 = new Email("Saluda", "Quiero saludar.", "Martin Martinez");
            em2.leer();






            Console.Read();
        }
    }
}
