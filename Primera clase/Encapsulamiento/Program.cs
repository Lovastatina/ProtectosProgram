using System;

namespace Encapsulamiento
{
    public class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria Pepe = new CuentaBancaria();

            Pepe.setPin(680);
            Pepe.setSaldo(1471.99f);
            
            Console.WriteLine("Tu pin es: " + Pepe.getPin());
            Console.WriteLine("Tu saldo actual es: " + Pepe.getSaldo());

            Console.Read();
        }
    }
}
