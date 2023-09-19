using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamiento
{
    public class CuentaBancaria
    {
        private int pin;
        private float saldo;

        public void setPin(int npin)
        {
            pin = npin;
        }

        public void setSaldo(float valor)
        {
            saldo = valor;
        }

        
        public int getPin()
        {
                return pin;
        }

        public float getSaldo()
        {
            if(getPin() != 0)
            {
                return saldo;
            }
            else
            {
               Console.WriteLine("PIN inválido. No se puede consultar el saldo");
                    return -777;
            }   
            
        }

        
       
    }
}
