using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Frete
    {
        private double distancia;
        private double peso;
        public Frete(double d, double p)
        {
            distancia = d;
            peso = p;
        }
        public virtual decimal CalcFrete()
        {
            return (decimal) (peso * distancia * 0.01);
        }
        public override string ToString()
        {
            return $"Frete: {CalcFrete()}";
        }
    }
}
