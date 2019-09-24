using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class QuadroMedalhas
    {
        private Pais[] paises = new Pais[15];
        private int k;
        public void Inserir(Pais p)
        {
            if(k < 15)
            paises[k++] = p;
        }
        public Pais[] Listar()
        {
            Pais[] vetor = new Pais[k];
            Array.Copy(paises, vetor, k);
            Array.Sort(vetor);
            return vetor;
        }
    }
}
