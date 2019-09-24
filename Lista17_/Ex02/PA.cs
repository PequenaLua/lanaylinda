using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class PA : Sequencia
    {
        private int pE, r, k, ele;
        public PA(int p, int ra)
        {
            pE = p;
            r = ra;
        }
        public void Iniciar() {
            k = -1;
            ele = pE;
        }
        public int Proximo()
        {
            k++;
            return (k == 0 ? ele : ele += r);
        }
    }
}
