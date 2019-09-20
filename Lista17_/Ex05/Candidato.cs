using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Candidato: IComparable
    {
        private string nome;
        private DateTime nascimento;
        private int pontos;
        public Candidato(string n, DateTime nasci, int p)
        {
            nome = n;
            nascimento = nasci;
            pontos = p;
        }
        public override string ToString()
        {
            return $"{nome} - {pontos} pontos - Data de nascimento {nascimento:dd/MM/yyyy}";
        }
        public int GetPontos() { return pontos; }
        public int CompareTo(object obj)
        {
            Candidato c = obj as Candidato;
            if (this.pontos > c.pontos) return -1;
            if (this.pontos < c.pontos) return 1;
            int s = this.nascimento.CompareTo(c.nascimento);
            if (s != 0) return s;
            else return this.nome.CompareTo(c.nome);
        }
    }
}
