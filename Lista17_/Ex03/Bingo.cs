using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Bingo: ISorteio
    {
        private int numBolas;
        private int[] sorteados;
        private int i;
        public Bingo(int n) {
            numBolas = n;
            sorteados = new int[numBolas];
            int k = 0;
            Random r = new Random();
            while (k < numBolas)
            {
                int m = r.Next(1, numBolas + 1);
                if (Array.IndexOf(sorteados, m) == -1)
                {
                    sorteados[k] = m;
                    k++;
                }
            }
            i = -1;
        }
        public int Sortear()
        {
            if (i < numBolas)
            {
                i++;
                return sorteados[i];
            }
            else return 0;
        }
        public int[] Sorteados()
        {
            int[] y = new int[i];
            Array.Copy(sorteados, y, i);
            return y;
        }
    }
}
