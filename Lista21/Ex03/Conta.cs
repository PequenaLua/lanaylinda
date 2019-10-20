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
            if (s < 0) throw new ArgumentOutOfRangeException("s", "O saldo não pode ser negativo");
            else saldo = s;
        }
        public void Depositar(decimal valor)
        {
            if (valor < 0) throw new ArgumentOutOfRangeException("valor", "O valor do depósito não pode ser negativo");
            else saldo += valor;
        }
        public bool Sacar(decimal valor)
        {
            if (valor < 0) throw new ArgumentOutOfRangeException("valor", "O valor do saque não pode ser negativo");
            else if (valor > saldo) throw new InversaoSaldoException("Você não possui esse valor");
            else return true;
        }
        public decimal VerificarSaldo()
        {
            return saldo;
        }

    }
}
