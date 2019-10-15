using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Poupanca: ContaCorrente
    {
        public Poupanca(string t, string n): base(t, n) { }
        public void RenderJuros(double juros)
        {
            saldo += saldo * juros;
        }
    }
}
