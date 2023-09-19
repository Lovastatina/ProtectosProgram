using System;

namespace Encapsulamiento
{
    public class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria Pepe = new CuentaBancaria();

            Pepe.setPin(0);
            Pepe.setSaldo(1471.99f);
            
            Console.WriteLine("Tu pin es: " + Pepe.getPin());
            Console.WriteLine("Tu saldo actual es de: " + Pepe.getSaldo() +"$" );

            Console.Read();
        }
    }
}
