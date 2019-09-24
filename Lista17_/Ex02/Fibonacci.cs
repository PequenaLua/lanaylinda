using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Fibonacci : Sequencia
    {
        private int f1, f2, f3;
        public void Iniciar()
        {
            f1 = 0;
            f2 = 1;
            f3 = 0;
        }
        public int Proximo()
        {
            f3 = f1;
            f1 = f2;
            f2 = f1 + f3;
            return f2;
        }
    }
}
