using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Bingo
    {
        private int numBolas = 50;
        private int[] bolas = new int[100];
        private int[] sorteadas = new int[100];
        private int j = 0;
        public void Iniciar(int numBolas)
        {
            this.numBolas = numBolas;
            for(int i = 0; i < 100; i++) bolas[i] = 0;
        }
        public int Proximo()
        {
            if (j < 50)
            {
                Random r = new Random();

                bool ok = false;
                int s = 0;
                while (ok == false)
                {
                    s = r.Next(1, numBolas);
                    for (int k = 0; k < 100; k++)
                    {
                        if (s == bolas[k])
                        {
                            ok = false;
                            break;
                        }
                        else ok = true;
                    }
                }
                sorteadas[j] = s;
                j++;
                return s;
            }
            else return 0;
        }
       public int[] Sorteados()
        {
            int[] vetor = new int[j];
            Array.Copy(sorteadas, vetor, j);
            Array.Sort(vetor);
            return vetor;
        }
    }
}
