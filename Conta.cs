using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basic_system_poo
{
    public class Conta
    {
        private float saldo;

        public float Sacar(float valor)
        {
            valor -= saldo;
            return valor;
        }
        public float Depositar(float valor)
        {
            valor += saldo;
            return valor;
        }
    }
}