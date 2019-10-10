using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class FreteExpresso:  Frete
    {
        private decimal seguro;
        public FreteExpresso(double p, double d, decimal s): base(d, p)
        {
            seguro = s;
        }
        public override decimal CalcFrete()
        {
            return base.CalcFrete()*2 + 0.01m*seguro;
        }
        public override string ToString()
        {
            return $"Seguro: {seguro} | Frete: {CalcFrete()} R$";
        }
    }
}
