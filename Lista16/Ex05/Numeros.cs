using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Numeros
    {
        private int inicio;
        private int fim;
        private int[] vetor = new int[200];
        private int m;
        public Numeros(int inicio, int fim)
        {
            this.inicio = inicio;
            this.fim = fim;
        }
        public int[] Calcular(bool p, bool i)
        {
            
            if(p == true && i == true)
            {
                m = 0;
                for (int k = inicio; k <= fim; k++)
                {
                    vetor[m] = k;
                    m++;
                }
            }
            if(p == true && i == false)
            {
                m = 0;
                for(int k = inicio; k <= fim; k++)
                {
                    if(k%2 == 0)
                    {
                        vetor[m] = k;
                        m++;
                    }
                }
            }
            if(p == false && i == true)
            {
                m = 0;
                for(int k = inicio; k <= fim; k++)
                {
                    if(k%2 != 0)
                    {
                        vetor[m] = k;
                        m++;
                    }
                }
            }
            int[] vet = new int[m];
            Array.Copy(vetor, vet, m);
            return vet;
        }
    }
}
