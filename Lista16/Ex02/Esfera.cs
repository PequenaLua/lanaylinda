using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Esfera
    {
        private double raio;
        public void SetRaio(double raio) { this.raio = raio; }
        public double GetRaio() { return raio; }
        public double CalcArea() { return 4 * Math.PI * Math.Pow(raio, 2); }
        public double CalcVolume() { return 4 * Math.PI * Math.Pow(raio, 3)/3; }

    }
}
