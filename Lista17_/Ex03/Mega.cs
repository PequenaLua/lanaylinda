using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Mega : ISorteio
    {
        private int[] sorteados = new int[6];
        private int k;
        private int i;
        public Mega(){
            k = 0; i = 0;
            Random r = new Random();
            while(k < 6)
            {
                int i = r.Next(1, 61);
                if(Array.IndexOf(sorteados, i) == -1)
                {
                    sorteados[k++] = i;
                }
            }
        }
        public int Sortear()
        {
            return (i < 6 ? sorteados[i++] : 0);
        }
        public int[] Sorteados()
        {
            int[] vetor = new int[i];
            Array.Copy(sorteados, vetor, i);
            return vetor;
        }
    }
}
