using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class ContaEspecial : ContaCorrente
    {
        private double limite;
        public ContaEspecial(string t, string n, double l): base(t, n)
        {
            if (l > 0) limite = l;
        }
        public override bool Sacar(double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            if(valor <= limite)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
