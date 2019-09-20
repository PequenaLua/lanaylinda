using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Concurso
    {
        Candidato[] candidatos = new Candidato[20];
        private int k;
        public void Inserir(Candidato c)
        {
            if(k < 20)
            candidatos[k++] = c;
        }
        public Candidato[] Listar()
        {
            Candidato[] novo = new Candidato[k];
            Array.Copy(candidatos, novo, k);
            Array.Sort(novo);
            return novo;
        }
        public Candidato[] Classificados()
        {
            int t = 0;
            Candidato[] cl = new Candidato[k];
            for(int i = 0; i < k; i++)
            {
                if(candidatos[i].GetPontos() >= 60) {
                    cl[t++] = candidatos[i];
                }
            }
            Candidato[] classicados = new Candidato[k];
            Array.Copy(cl, classicados, t);
            Array.Sort(classicados);
            return classicados;
        }
    }
}
