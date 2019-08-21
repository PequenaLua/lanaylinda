using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class EquacaoIIGrau
    {
        private double a;
        private double b;
        private double c;
        public void SetABC(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void GetABC(out double a, out double b, out double c)
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }
        public bool RaizesReais()
        {
            double raiz = b * b - 4 * a * c;
            if (raiz >= 0) return true;
            else return false;
        }
        public double Delta()
        {
            return b * b - 4 * a * c;
        }
        public bool X1(out double x)
        {
            double delta = Math.Sqrt(b * b - 4 * a * c);
            x = -b + delta / 2 * a;
            double raiz = b * b - 4 * a * c;
            if (raiz >= 0) return true;
            else return false;
        }
        public bool X2(out double x)
        {
            double delta = Math.Sqrt(b * b - 4 * a * c);
            x = -b - delta / 2 * a;
            double raiz = b * b - 4 * a * c;
            if (raiz >= 0) return true;
            else return false;
        }
    }
}
