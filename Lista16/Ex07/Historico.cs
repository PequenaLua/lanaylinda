using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Historico
    {
        private string aluno;
        private Disciplina[] discs = new Disciplina[15];
        private int m;
        public void SetNome(string a) {aluno = a;}
        public void Inserir(Disciplina d)
        {
            if(m < 15) { 
               discs[m] = d;
                m++;
            }
        }
        public Disciplina[] Listar()
        {
            Disciplina[] vetor = new Disciplina[m];
            Array.Copy(discs, vetor, m);
            return vetor;
        }
        public void Apagar(int sel)
        {
            for(int l = sel + 1; l < m; l++)
            {
                discs[l - 1] = discs[l]; 
            }
            discs[m] = null;
            m--;
        }
        public double CalcularIRA()
        {
            double ira = 0;
            for(int k = 0; k < m; k++)
            {
                ira += discs[k].GetMedia();
            }
            ira = ira / m;
            return ira;
        }
    }
    class Disciplina
    {
        private string nome, semestre;
        private double media;
        private bool aprovado;
        public Disciplina(string nome, string semestre, double media, bool aprovado)
        {
            this.nome = nome;
            this.semestre = semestre;
            this.media = media;
            this.aprovado = aprovado;
        }
        public double GetMedia()
        {
            return media;
        }
        public override string ToString()
        {
            if (aprovado == true)
                return $"{nome} - {semestre} - {media:0} - Aprovado";
            else
                return $"{nome} - {semestre} - {media:0} - Não aprovado";
        }
    }
}
