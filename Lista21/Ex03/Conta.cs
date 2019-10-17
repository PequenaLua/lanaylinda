using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Conta
    {
        private string numero;
        private decimal saldo;
        public Conta(string n, decimal s)
        {
            numero = n;
            saldo = s;
        }
        public void Depositar(decimal valor)
        {
            saldo += valor;
        }
        public bool Sacar(decimal valor)
        {
            if (valor > saldo)
                throw new InversaoSaldoException("Você não possui esse valor");
            else return true;
        }
        public decimal VerificarSaldo()
    }
}
