using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Bingo
    {
        private int numBolas;
        private int[] v;
        private int c;
        public void Iniciar(int n)
        {
            if(n >= 10 && n <= 100)
            numBolas = n;
            v = new int[numBolas];
            int k = 0;
            Random r = new Random();
            while (k < numBolas)
            {
                int m = r.Next(1, numBolas + 1);
                if (Array.IndexOf(v, m) == -1)
                {
                    v[k] = m;
                    k++;
                }
            }
        }
        public int Proximo()
        {
            if (c < numBolas)
            {
                int x = v[c];
                c++;
                return x;
            }
            return -1;
        }

    }
}
