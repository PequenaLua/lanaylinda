using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Retangulo
    {
        private double b;
        private double a;
        public void SetBase(double b) { this.b = b; }
        public void SetAltura(double a) { this.a = a; }
        public double GetBase() { return b; }
        public double GetAltura() { return a; }
        public double CalcArea() { return b * a; }
        public double CalcDiagonal() { return Math.Sqrt(a * a + b * b); }
    }
}
