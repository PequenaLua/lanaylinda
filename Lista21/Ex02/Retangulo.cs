using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Retangulo
    {
        private int b, h;
        public void SetBase(int b)
        {
            if (b < 0) throw new ArgumentOutOfRangeException("b", "Base inválida");
            else this.b = b;
        }
        public void SetAltura(int h)
        {
            if (h < 0) throw new ArgumentOutOfRangeException("h", "Altura inválida");
            else this.h = h;
        }
        public int CalcArea()
        {
            return h * b;
        }
    }
}
